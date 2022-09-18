using UnityEngine;

namespace ForestOfMysteries.Trees
{
    public class LookAtTarget : MonoBehaviour
    {
        private Transform _target;

        internal void Init(Transform target)
        {
            _target = target;
            enabled = true;
        }

        internal void Disable()
        {
            enabled = false;
        }
        
        private void Update()
        {
            transform.LookAt(_target);
        }
    }
}