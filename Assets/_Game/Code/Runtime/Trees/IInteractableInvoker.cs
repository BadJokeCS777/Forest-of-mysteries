using System;

namespace ForestOfMysteries.Trees
{
    public interface IInteractableInvoker
    {
        public event Action Interacted;
    }
}