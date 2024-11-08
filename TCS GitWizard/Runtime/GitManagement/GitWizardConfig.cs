using System;
using System.Collections.Generic;
using UnityEngine;

namespace TCS.GitWizard {
    [CreateAssetMenu(menuName = "TCS/GitWizard/Create GitWizardConfig", fileName = "GitWizardConfig", order = 1000)]
    public class GitWizardConfig : ScriptableObject {
        [Header("Installer Title")]
        public string m_installerTitle;
        [Header("Github Repository's Configuration")]
        public List<GitPackageInfo> m_owners = new();

        public Action ConfigChanged;
        public void InvokeEvent() => ConfigChanged?.Invoke();
    }
}