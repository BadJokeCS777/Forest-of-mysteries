using UnityEngine;

namespace ForestOfMysteries.Trees
{
    public class ArrowSelector : MonoBehaviour
    {
        [SerializeField] private ArrowButton[] _buttons;
        [SerializeField] private ArrowSpawner _arrowSpawner;
        [SerializeField] private MonoBehaviour _tree;

        private IReadOnlyTree Tree => (IReadOnlyTree) _tree;

        private void OnValidate()
        {
            if (_tree is IReadOnlyTree)
                return;
            
            Debug.LogError($"{_tree.name} must inherit {nameof(IReadOnlyTree)}");
        }

        private void Start()
        {
            transform.localScale = Vector3.zero;
            
            Hide();
             
            Tree.Interacted += OnInteracted;

            foreach (ArrowButton button in _buttons)
                button.Click += OnButtonClick;
        }

        private void OnInteracted()
        {
            Show();
        }

        private void OnButtonClick(ArrowDirection direction)
        {
            _arrowSpawner.Spawn(direction, Tree.ArrowPoint);
            
            Tree.Interacted -= OnInteracted;

            foreach (ArrowButton button in _buttons)
                button.Click -= OnButtonClick;
            
            Hide();
        }

        private void Show()
        {
            transform.localScale = Vector3.one;
        }

        private void Hide()
        {
            transform.localScale = Vector3.zero;
        }
    }
}