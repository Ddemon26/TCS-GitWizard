﻿using System;
using UnityEngine;
using UnityEngine.UIElements;
namespace TCS.GitWizard {
    [HelpURL("https://github.com/Ddemon26/TCS-GitWizard/blob/main/README.md")]
    [Serializable]
    public class PackageSingle : IDisposable {
        VisualElement m_container;

        public string m_repoName;
        public string m_url;
        public string m_description;

        const string REPO_NAME = "repo-name";
        Label m_repoLabel;
        const string BUTTON_INSTALL = "install";
        Button m_install;
        const string BUTTON_LINK = "link";
        Button m_link;
        const string REPO_DESCRIPTION = "repo-description";
        Label m_descriptionLabel;

        const string URL_PREFIX = "git+";

        public PackageSingle(string repoLabel, string url, string description) {
            m_repoName = repoLabel;
            m_url = url;
            if (!IsUrlValid()) {
                Debug.LogError("Invalid URL");
            }

            m_description = description;
        }

        public void SetVisualElement(VisualElement container) {
            m_container = container;
            if (m_container == null) {
                Debug.LogError("Container is null");
                return;
            }

            container.AddToClassList("group-padding");

            m_repoLabel = m_container.Q<Label>(REPO_NAME);
            if (m_repoLabel == null) {
                Debug.LogError($"Label with name '{REPO_NAME}' not found in container");
                return;
            }

            m_repoLabel.text = m_repoName;

            m_install = m_container.Q<Button>(BUTTON_INSTALL);
            if (m_install == null) {
                Debug.LogError($"Button with name '{BUTTON_INSTALL}' not found in container");
                return;
            }

            m_install.clicked += InstallPackage;

            m_link = m_container.Q<Button>(BUTTON_LINK);
            if (m_link == null) {
                Debug.LogError($"Button with name '{BUTTON_LINK}' not found in container");
                return;
            }

            m_link.clicked += OpenUrl;

            m_descriptionLabel = m_container.Q<Label>(REPO_DESCRIPTION);
            if (m_descriptionLabel == null) {
                Debug.LogError($"Label with name '{REPO_DESCRIPTION}' not found in container");
                return;
            }

            if (string.IsNullOrEmpty(m_description)) {
                var foldout = m_container.Q<Foldout>();
                foldout.style.display = DisplayStyle.None;
            }
            else {
                m_descriptionLabel.text = m_description;
            }
        }
        void SetButton() {
            m_install = m_container.Q<Button>(BUTTON_INSTALL);
            m_install.clicked += InstallPackage;
        }
        void SetLink() {
            m_link = m_container.Q<Button>(BUTTON_LINK);
            m_link.clicked += OpenUrl;
        }

        public void InstallPackage() {
            if (!IsUrlValid()) return;
#if UNITY_EDITOR
            GitPackageHandler.InstallPackage($"{URL_PREFIX}{m_url}");
#endif
            //m_install.SetEnabled(false);
            Debug.Log($"Installing {m_repoName}");
        }
        void OpenUrl() {
            if (!IsUrlValid()) return;
#if UNITY_EDITOR
            GitPackageHandler.OpenPackageUrl(m_url);
#endif
            Debug.Log($"Opening {m_repoName}");
        }
        bool IsUrlValid() => !string.IsNullOrEmpty(m_url);
        public void Unsubscribe() {
            m_install.clicked -= InstallPackage;
            m_link.clicked -= OpenUrl;
            m_install = null;
            m_link = null;
            m_container.Clear();
        }

        public void Dispose() => Unsubscribe();
    }
}