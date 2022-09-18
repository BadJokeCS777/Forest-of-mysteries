using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ForestOfMysteries.TimeEvent
{
    public class TemporaryEvent : MonoBehaviour
    {
        public event UnityAction EyesRunning;
        public event UnityAction FootstepsSoundStart;
        public event UnityAction FootstepsSoundStop;

        private readonly WaitForSeconds _timerEyesRunEvent = new WaitForSeconds(150);
        private readonly WaitForSeconds _timerFootstepsSoundEvent = new WaitForSeconds(600);
        private readonly WaitForSeconds _playFootstepsSoundEvent = new WaitForSeconds(10);

        private bool _gameOver = false;

        private void Start()
        {
            StartCoroutine(StartTimerFootstepsSound());
            StartCoroutine(StartTimerRedEyes());
        }

        private IEnumerator StartTimerFootstepsSound()
        {
            while (_gameOver == false)
            {
                yield return _timerFootstepsSoundEvent;
                FootstepsSoundStart?.Invoke();

                yield return _playFootstepsSoundEvent;
                FootstepsSoundStop?.Invoke();
            }
        }

        private IEnumerator StartTimerRedEyes()
        {
            while (_gameOver == false)
            {
                yield return _timerEyesRunEvent;
                EyesRunning?.Invoke();
            }
        }
    }
}