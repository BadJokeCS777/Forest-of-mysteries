using UnityEngine;

namespace ForestOfMysteries.Trees
{
    public class LookAtTargetTreeController : MonoBehaviour
    {
        [SerializeField] private Transform _player;
        [SerializeField] private MonoBehaviour _tree;
        [SerializeField] private LookAtTarget _lookAtTarget;

        private IReadOnlyTree Tree => (IReadOnlyTree) _tree;

        private void OnValidate()
        {
            if (_tree is IReadOnlyTree)
                return;
            
            Debug.LogError($"{_tree.name} must inherit {nameof(IReadOnlyTree)}");
        }

        private void Start()
        {
            Tree.Interacted += OnInteracted;
            _lookAtTarget.Init(_player);
        }

        private void OnInteracted()
        {
            Tree.Interacted -= OnInteracted;
            _lookAtTarget.Disable();
        }
    }
}