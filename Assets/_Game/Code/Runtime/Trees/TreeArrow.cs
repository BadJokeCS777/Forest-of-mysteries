using UnityEngine;

namespace ForestOfMysteries.Trees
{
    public class TreeArrow : MonoBehaviour
    {
        [SerializeField] private ArrowDirection _direction;

        public bool CompareDirection(ArrowDirection direction)
        {
            return direction == _direction;
        }
    }
}