using System.Collections.Generic;
using UnityEngine;
namespace TCS.GitWizard {
    [CreateAssetMenu(menuName = "Create GitWizardConfig", fileName = "GitWizardConfig", order = 0)]
    public class GitWizardConfig : ScriptableObject {
        public List<GitPackageInfo> m_owners;
    }
}