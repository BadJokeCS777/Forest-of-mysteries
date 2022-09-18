﻿using System;
using ForestOfMysteries.Common;
using UnityEngine;
using UnityEngine.AI;

namespace ForestOfMysteries.Enemy
{
    public class CharacterNavigator : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _navMeshAgent;

        public void Move(Vector3 destination, Action onComplete = null)
        {
            _navMeshAgent.SetDestination(destination);
            this.InvokeAfterDelay(() => this.WaitWhile(PathIsComplete, onComplete), 1f);
        }
        

        private bool PathIsComplete()
        {
            Debug.Log("_navMeshAgent.remainingDistance = " + _navMeshAgent.remainingDistance);

            return _navMeshAgent.remainingDistance <= 0.1f;
        }
    }
}