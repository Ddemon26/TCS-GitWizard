using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS.GitWizard {
    [CreateAssetMenu(menuName = "TCS/GitWizard/Create GitWizardConfig", fileName = "GitWizardConfig", order = 1000)]
    public class GitWizardConfig : ScriptableObject {
        public string m_installerTitle;
        public List<GitPackageInfo> m_owners = new();

        public Action OnConfigChanged;
        public void InvokeEvent() => OnConfigChanged?.Invoke();
    }
}