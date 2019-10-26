using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Chapter1
{
    public class EnemyChase : MonoBehaviour
    {
        public LayerMask detectionLayer;
        private Transform myTransform;
        private NavMeshAgent myNavMeshAgent;
        private Collider[] hitColliders;
        private float checkRate;
        private float nextCheck;
        private float detectionradius = 10;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            CheckIfPlayerInRange();
        }

        void SetInitialReferences()
        {
            myTransform = transform;
            myNavMeshAgent = GetComponent<NavMeshAgent>();
            checkRate = Random.Range(0.8f, 1.2f);
        }

        void CheckIfPlayerInRange()
        {
            if (Time.time > nextCheck && myNavMeshAgent.enabled)
            {
                nextCheck = Time.time + checkRate;
                hitColliders = Physics.OverlapSphere(myTransform.position, detectionradius, detectionLayer);
                if (hitColliders.Length > 0)
                {
                    myNavMeshAgent.SetDestination(hitColliders[0].transform.position);
                }
            }
        }
    }
}