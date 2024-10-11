using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace TCS.GitWizard {
    public class PackageOwner : IDisposable {
        VisualElement m_containerPrefab;
        
        string m_ownerName;
        Label m_ownerLabel;
        const string LABEL_NAME = "owner-name";
        
        VisualElement m_buttonContainer;
        const string BUTTON_CONTAINER = "button-container"; //holds the element container prefabs
        
        Button m_installAllButton;
        const string INSTALL_ALL_BUTTON_TEXT = "install-all";
        
        VisualElement[] m_elementContainerPrefab;

        readonly List<PackageInfo> m_packageInfoInfos;
        List<PackageSingle> m_packages;

        public int PackageCount;
        
        public PackageOwner(string ownerName, List<PackageInfo> packageInfos) {
            m_ownerName = ownerName;
            m_packageInfoInfos = packageInfos;
            
            PackageCount = m_packageInfoInfos.Count;
        }   
        
        void PopulatePackages() {
            m_packages = new List<PackageSingle>();
            foreach (var package in m_packageInfoInfos) {
                m_packages.Add(new PackageSingle(package.m_repoName, package.m_url));
            }
        }

        public void PopulateElements(VisualElement container, VisualElement[] elementContainers) {
            PopulatePackages();
            m_containerPrefab = container;
            m_elementContainerPrefab = elementContainers;
            
            m_buttonContainer = m_containerPrefab.Q<VisualElement>(BUTTON_CONTAINER);
            m_ownerLabel = m_containerPrefab.Q<Label>(LABEL_NAME);
            m_ownerLabel.text = m_ownerName;
            
            for (var i = 0; i < m_packages.Count; i++) {
                if (i >= m_elementContainerPrefab.Length) {
                    Debug.LogError("Not enough element containers for all packages");
                    return;
                }
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