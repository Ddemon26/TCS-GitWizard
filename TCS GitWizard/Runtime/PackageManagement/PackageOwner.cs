using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace TCS.GitWizard {
    [HelpURL("https://github.com/Ddemon26/TCS-GitWizard/blob/main/README.md")]
    public class PackageOwner : IDisposable {
        VisualElement m_containerPrefab;

        readonly string m_ownerName;
        Label m_ownerLabel;
        const string LABEL_NAME = "owner-name";

        VisualElement m_buttonContainer;
        const string BUTTON_CONTAINER = "button-container"; //holds the element container prefabs

        VisualElement m_installAllContainer;
        const string INSTALL_ALL_CONTAINER = "install-all__container";
        Button m_installAllButton;
        const string INSTALL_ALL_BUTTON_TEXT = "install-all__button";

        VisualElement[] m_elementContainerPrefab;

        readonly List<PackageInfo> m_packageInfoInfos;
        List<PackageSingle> m_packages;

        public readonly int PackageCount;

        public PackageOwner(string ownerName, List<PackageInfo> packageInfos) {
            m_ownerName = ownerName;
            m_packageInfoInfos = packageInfos;

            PackageCount = m_packageInfoInfos.Count;
        }

        void PopulatePackages() {
            m_packages = new List<PackageSingle>();
            foreach (var package in m_packageInfoInfos) {
                m_packages.Add(new PackageSingle(package.m_repoName, package.m_url, package.m_description));
            }
        }

        public void PopulateElements(VisualElement container, VisualElement[] elementContainers) {
            PopulatePackages();
            m_containerPrefab = container;
            m_elementContainerPrefab = elementContainers;

            m_buttonContainer = m_containerPrefab.Q<VisualElement>(BUTTON_CONTAINER);
            m_ownerLabel = m_containerPrefab.Q<Label>(LABEL_NAME);
            m_ownerLabel.text = m_ownerName;

            m_installAllContainer = m_containerPrefab.Q<VisualElement>(INSTALL_ALL_CONTAINER);
            m_installAllButton = m_containerPrefab.Q<Button>(INSTALL_ALL_BUTTON_TEXT);
            if (m_packages.Count > 1) {
                m_installAllButton.clicked += () => {
                    foreach (var package in m_packages) {
                        package.InstallPackage();
                    }
                };
            }
            else {
                m_installAllContainer.style.display = DisplayStyle.None;
            }

            // Ensure there are enough element containers
            if (m_packages.Count > m_elementContainerPrefab.Length) {
                int additionalContainersNeeded = m_packages.Count - m_elementContainerPrefab.Length;
                List<VisualElement> newElementContainers = new(m_elementContainerPrefab);

                for (var i = 0; i < additionalContainersNeeded; i++) {
                    var newContainer = new VisualElement();
                    newElementContainers.Add(newContainer);
                }

                m_elementContainerPrefab = newElementContainers.ToArray();
            }

            for (var i = 0; i < m_packages.Count; i++) {
                var elementContainer = m_elementContainerPrefab[i];
                m_packages[i].SetVisualElement(elementContainer);
                m_buttonContainer.Add(elementContainer);
            }
        }
        public void Dispose() {
            foreach (var package in m_packages) {
                package.Dispose();
            }

            m_packages.Clear();
            m_containerPrefab.Clear();
        }
    }
}