using UnityEngine;

namespace ForestOfMysteries.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private EnemyAnimator _animator;
        [SerializeField] private CharacterNavigator _navigator;
        [SerializeField] private float _angle = 45f;
        [SerializeField] private float _distance = 10f;



        [ContextMenu(nameof(Scare))]
        public void Scare()
        {
            Show();

            transform.position = CalculatePositionAtTargetFromAngle(_target, -_angle);
            Vector3 position = CalculatePositionAtTargetFromAngle(_target, _angle);
            _navigator.Move(position, onComplete: Stop);
            _animator.Move = true;
        }

        private Vector3 CalculatePositionAtTargetFromAngle(Transform target, float angle)
        {
            Quaternion quaternion = Quaternion.Euler(0,angle,0);
            return quaternion * target.forward * _distance;
        }

        private void Stop()
        {
            _animator.Move = false;
            Hide();
        }

        private void Hide() => 
            gameObject.SetActive(false);
        private void Show() => 
            gameObject.SetActive(true);
    }
}