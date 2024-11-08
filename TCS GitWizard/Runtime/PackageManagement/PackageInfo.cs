using System;
using UnityEngine;
namespace TCS.GitWizard {
    [Serializable]
    public struct PackageInfo {
        [Header("Package Information")]
        [Tooltip("The name of the repository")]
        public string m_repoName;
        [Tooltip("The URL of the repository")]
        public string m_url;

        [Header("Package Description (Optional)")]
        [Tooltip("A description of the package (NOTE: if this is empty, the description will not be displayed)")]
        [TextArea] public string m_description;
    }
}