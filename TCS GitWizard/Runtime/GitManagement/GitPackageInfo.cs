using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS.GitWizard {
    [Serializable]
    public class GitPackageInfo : ScriptableObject {
        [Header("Repository Owners Name")]
        public string m_ownerName;
        [Header("Packages")]
        public List<PackageInfo> m_packageInfos = new();
    }
}