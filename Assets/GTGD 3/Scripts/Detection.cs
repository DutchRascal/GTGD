using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class Detection : MonoBehaviour
    {
        private RaycastHit hit;
        private LayerMask detectionLayer;
        private float checkRate = 0.5f;
        private float range = 5f;
        private float nextCheck;
        private Transform myTransform;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            DetectItems();
        }

        void SetInitialReferences()
        {
            myTransform = transform;
            detectionLayer = 1 << 9;
        }

        void DetectItems()
        {
            if (Time.time > nextCheck)
            {
                nextCheck = Time.time + checkRate;
                if (Physics.Raycast(myTransform.position, myTransform.forward, out hit, range, detectionLayer))
                {
                    Debug.Log(hit.transform.name + " is an item");
                }
            }
        }
    }
}