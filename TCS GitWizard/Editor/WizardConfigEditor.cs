using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
namespace TCS.GitWizard.Editor {
    [CustomEditor(typeof(GitWizardConfig))]
    public class WizardConfigEditor : UnityEditor.Editor {
        [SerializeField] VisualTreeAsset m_visualTreeAsset;
        PropertyField m_ownersField;
        PropertyField m_installerTitleField;

        public override VisualElement CreateInspectorGUI() {
            var root = new VisualElement();
            VisualElement labelFromUxml = m_visualTreeAsset.Instantiate();
            root.Add(labelFromUxml);

            // Create a PropertyField for the m_installerTitle field
            m_installerTitleField = new PropertyField(serializedObject.FindProperty("m_installerTitle"));
            m_installerTitleField.Bind(serializedObject);
            root.Add(m_installerTitleField);

            // Create a PropertyField for the m_owners field
            m_ownersField = new PropertyField(serializedObject.FindProperty("m_owners"));
            m_ownersField.Bind(serializedObject);
            root.Add(m_ownersField);

            // Add a Button to invoke the OnConfigChanged event
            var invokeButton = new Button(() => ((GitWizardConfig)target).InvokeEvent()) {
                text = "Refresh EditorWindow",
            };
            root.Add(invokeButton);

            // Add a button to create new GitPackageInfo
            var createButton = new Button(CreateNewGitPackageInfo) {
                text = "Create New GitPackageInfo",
            };
            root.Add(createButton);

            // Add a button to remove all GitPackageInfos
            var removeAllButton = new Button(RemoveMissingGitPackageInfos) {
                text = "Remove Missing GitPackageInfos",
            };
            root.Add(removeAllButton);

            return root;
        }

        void CreateNewGitPackageInfo() {
            // Create a new GitPackageInfo instance
            var newPackageInfo = CreateInstance<GitPackageInfo>();
            newPackageInfo.m_ownerName = "New Owner";

            // Add the new instance to the GitWizardConfig
            var config = (GitWizardConfig)target;

            // Ensure m_owners is initialized
            config.m_owners ??= new List<GitPackageInfo>();

            config.m_owners.Add(newPackageInfo);

            // Save the new instance as a sub-asset of the config
            newPackageInfo.name = "gitInfo_" + config.m_owners.Count;
            AssetDatabase.AddObjectToAsset(newPackageInfo, config);
            AssetDatabase.SaveAssets();

            // Mark the config as dirty to ensure it gets saved
            EditorUtility.SetDirty(config);
        }

        //method to remove all the missing children from the GitWizardConfig
        void RemoveMissingGitPackageInfos() {
            var config = (GitWizardConfig)target;
            if (config.m_owners == null) return;

            // Get all sub-assets of the config
            Object[] subAssets = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(config));

            // Create a HashSet of the current m_owners for quick lookup
            HashSet<GitPackageInfo> ownerSet = new(config.m_owners);

            foreach (var subAsset in subAssets) {
                if (subAsset is GitPackageInfo gitPackageInfo && !ownerSet.Contains(gitPackageInfo)) {
                    // Remove the sub-asset from the parent asset
                    AssetDatabase.RemoveObjectFromAsset(gitPackageInfo);
                }
            }

            // Save the changes to the asset database
            AssetDatabase.SaveAssets();
            EditorUtility.SetDirty(config);
        }
    }
}