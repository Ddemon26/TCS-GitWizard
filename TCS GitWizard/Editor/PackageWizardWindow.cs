using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
namespace TCS.GitWizard.Editor {
    public class PackageWizardWindow : EditorWindow {
        [SerializeField] VisualTreeAsset m_visualTreeAsset;
        [SerializeField] VisualTreeAsset m_ownerContainer;
        [SerializeField] VisualTreeAsset m_elementContainer;
        [SerializeField] GitWizardConfig m_gitConfig;

        List<PackageOwner> m_owners;
        VisualElement m_scrollView;

        const string SCROLL_VIEW_NAME = "scroll-container";
        const string GROUP_BORDER = "group-border";

        [MenuItem("Tools/Tent City Studio/PackageWizard")]
        public static void OpenWindow() {
            var wnd = GetWindow<PackageWizardWindow>();
            wnd.titleContent = new GUIContent("PackageWizardWindow");
        }

        void OnEnable() {
            m_owners = new List<PackageOwner>();

            //populate the owners list
            foreach (var owner in m_gitConfig.m_owners) {
                m_owners.Add(new PackageOwner(owner.m_ownerName, owner.m_packageInfos));
            }
        }

        public void CreateGUI() {
            var root = rootVisualElement;
            VisualElement labelFromUxml = m_visualTreeAsset.Instantiate();
            root.Add(labelFromUxml);

            m_scrollView = root.Q<ScrollView>(SCROLL_VIEW_NAME);
            if (m_scrollView == null) {
                Debug.LogError("Scroll view instantiation failed");
            }

            //create a OwnerContainer for each owner and populate it with the owner's packages
            foreach (var owner in m_owners) {
                var ownerContainer = OwnerContainer();
                ownerContainer.AddToClassList(GROUP_BORDER); //add a border to the owner container
                int elementContainers = owner.PackageCount; //number of packages the owner has
                owner.PopulateElements
                (
                    ownerContainer,
                    ElementContainer(elementContainers)
                );
                m_scrollView?.Add(ownerContainer);
            }
        }
        VisualElement OwnerContainer() {
            VisualElement ownerContainer = m_ownerContainer.Instantiate();
            return ownerContainer;
        }
        VisualElement[] ElementContainer(int count) {
            if (count <= 0) {
                Debug.LogError("Element container count must be greater than 0");
                return null;
            }

            VisualElement[] elementContainers = new VisualElement[count];
            for (var i = 0; i < count; i++) {
                elementContainers[i] = m_elementContainer.Instantiate();
                if (elementContainers[i] == null) {
                    Debug.LogError("Element container instantiation failed");
                }
            }

            return elementContainers;
        }

        void OnDisable() {
            foreach (var owner in m_owners) {
                owner.Dispose();
            }
            m_owners.Clear();
        }
    }
}