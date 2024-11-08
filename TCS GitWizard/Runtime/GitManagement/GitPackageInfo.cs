using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS.GitWizard {
    [HelpURL("https://github.com/Ddemon26/TCS-GitWizard/blob/main/README.md")]
    [Serializable]
    public class GitPackageInfo : ScriptableObject {
        [Header("Repository Owners Name")]
        public string m_ownerName;
        [Header("Packages")]
        public List<PackageInfo> m_packageInfos = new();
    }
}