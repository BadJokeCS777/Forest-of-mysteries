using System;
using UnityEngine;

namespace ForestOfMysteries.Trees
{
    [RequireComponent(typeof(CapsuleCollider))]
    public class Tree : MonoBehaviour
    {
        [SerializeField] private Transform _notePoint;

        public event Action Interacted;
    
        public Transform NotePoint => _notePoint;
    
        [ContextMenu(nameof(Interact))]
        public void Interact()
        {
            Interacted?.Invoke();
        }
    }
}