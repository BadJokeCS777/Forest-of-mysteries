using UnityEngine;

namespace ForestOfMysteries.Trees
{
    public interface IReadOnlyTree : IInteractableInvoker
    {
        public Transform NotePoint { get; }
        public Transform ArrowPoint { get; }
    }
}