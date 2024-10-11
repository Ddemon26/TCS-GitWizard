using System.Collections.Generic;
using UnityEngine;
namespace TCS.GitWizard {
    [CreateAssetMenu(menuName = "TCS/GitWizard/Create GitWizardConfig", fileName = "GitWizardConfig", order = 1000)]
    public class GitWizardConfig : ScriptableObject {
        public List<GitPackageInfo> m_owners;
    }
}