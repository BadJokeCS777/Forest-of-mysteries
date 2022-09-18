using System;
using UnityEngine;

namespace ForestOfMysteries.Trees
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class Tree : MonoBehaviour, IReadOnlyTree, IInteractable
    {
        [SerializeField] private Transform _notePoint;
        [SerializeField] private Transform _arrowPoint;
 
        public event Action Interacted;
    
        public Transform NotePoint => _notePoint;
        public Transform ArrowPoint => _arrowPoint;

        [ContextMenu(nameof(Interact))]
        public void Interact()
        {
            Interacted?.Invoke();
        }
    }
}