using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
namespace TCS.GitWizard {
    internal static class GitPackageHandler {
        static AddRequest sRequest;
        static readonly Queue<string> PackagesToInstall = new();

        // Method to install a single package
        public static void InstallPackage(string package) {
            PackagesToInstall.Enqueue(package);

            // If no other package is being installed, start the process
            if (PackagesToInstall.Count == 1) {
                StartNextPackageInstallation();
            }
        }

        // Method to install multiple packages
        public static void InstallPackages(string[] packages) {
            foreach (string package in packages) {
                PackagesToInstall.Enqueue(package);
            }

            // If the queue wasn't already processing, start the process
            if (PackagesToInstall.Count > 0 && sRequest == null) {
                StartNextPackageInstallation();
            }
        }

        // Handles the actual installation process asynchronously
        static async void StartNextPackageInstallation() {
            if (PackagesToInstall.Count == 0) {
                return;
            }

            // Get the next package to install
            sRequest = Client.Add(PackagesToInstall.Dequeue());

            // Wait for the request to complete
            while (!sRequest.IsCompleted) {
                await Task.Delay(10);
            }

            switch (sRequest.Status) {
                // Check the request status
                case StatusCode.Success:
                    Debug.Log("Installed: " + sRequest.Result.packageId);
                    break;
                case >= StatusCode.Failure:
                    Debug.LogError(sRequest.Error.message);
                    break;
            }

            // Reset the request for the next package installation
            sRequest = null;

            // If there are more packages in the queue, install the next one
            if (PackagesToInstall.Count <= 0) return;
            await Task.Delay(1000); // Optionally delay between installations
            StartNextPackageInstallation();
        }
        
        // Method to open a URL link without the git+ prefix
        public static void OpenPackageUrl(string packageUrl) {
            if (string.IsNullOrEmpty(packageUrl)) {
                Debug.LogError("Package URL is null or empty.");
                return;
            }

            // Open the URL
            Application.OpenURL(packageUrl);
        }
        //method to uninstall a package
        public static void UninstallPackage(string package) {
            Client.Remove(package);
        }
    }
}