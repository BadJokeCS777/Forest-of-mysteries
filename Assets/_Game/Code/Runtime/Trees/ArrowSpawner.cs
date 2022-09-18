using System;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ForestOfMysteries.Trees
{
    [Serializable]
    internal class ArrowSpawner
    {
        [SerializeField] private TreeArrow[] _prefabs;
        
        internal void Spawn(ArrowDirection direction, Transform point)
        {
            TreeArrow prefab = _prefabs.First(arrow => arrow.CompareDirection(direction));
            Object.Instantiate(prefab, point.position, point.rotation, point);
        }
    }
}