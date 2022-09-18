using System;
using UnityEngine;
using UnityEngine.UI;

namespace ForestOfMysteries.Trees
{
    public class ArrowButton : MonoBehaviour
    {
        [SerializeField] private ArrowDirection _direction;
        [SerializeField] private Button _button;

        public event Action<ArrowDirection> Click;
        
        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            Click?.Invoke(_direction);
        }
    }
}