using UnityEngine;

namespace ForestOfMysteries.Enemy
{
    public class EnemyAnimator : MonoBehaviour
    {
        private static readonly int MOVE = Animator.StringToHash("Move");
        
        [SerializeField] private Animator _animator;

        public bool Move
        {
            get => _animator.GetBool(MOVE);
            set => _animator.SetBool(MOVE, value);
        }
    }
}