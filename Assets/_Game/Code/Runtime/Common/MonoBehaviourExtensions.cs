using System;
using System.Collections;
using UnityEngine;

namespace ForestOfMysteries.Common
{
    public static class MonoBehaviourExtensions
    {
        public static void InvokeAfterDelay(this MonoBehaviour monoBehaviour, Action action, float delay) =>
            monoBehaviour.StartCoroutine(InvokeAfterDelay(action, delay));

        private static IEnumerator InvokeAfterDelay(Action action, float delay)
        {
            yield return new WaitForSeconds(delay);
            action?.Invoke();
        }

        public static void
            WaitUntil(this MonoBehaviour monoBehaviour, Func<bool> predicate, Action onComplete = null) =>
            monoBehaviour.StartCoroutine(WaitUntil(predicate, onComplete));

        public static void
            WaitWhile(this MonoBehaviour monoBehaviour, Func<bool> predicate, Action onComplete = null) =>
            monoBehaviour.StartCoroutine(WaitWhile(predicate, onComplete));

        private static IEnumerator WaitUntil(Func<bool> predicate, Action onComplete)
        {
            yield return new WaitUntil(predicate);
            onComplete?.Invoke();
        }

        private static IEnumerator WaitWhile(Func<bool> predicate, Action onComplete)
        {
            yield return new WaitWhile(predicate);
            onComplete?.Invoke();
        }
    }
}