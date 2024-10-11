using System;
using System.Collections.Generic;
using UnityEngine;
namespace TCS.GitWizard {
    [Serializable]
    public class GitPackageInfo : ScriptableObject {
        public string m_ownerName;
        public List<PackageInfo> m_packageInfos = new();
    }
}   