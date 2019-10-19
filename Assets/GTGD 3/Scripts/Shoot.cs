using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class Shoot : MonoBehaviour
    {
        private float fireRate = 0.3f;
        private float nextFire;
        private RaycastHit hit;
        private float range = 300;
        private Transform myTransform;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            CheckForInput();
        }

        void SetInitialReferences()
        {
            myTransform = transform;
        }

        void CheckForInput()
        {
            if (Input.GetButton("Fire1") && Time.time > nextFire)
            {
                Debug.DrawRay(myTransform.TransformPoint(0, 0, 1), myTransform.forward, Color.green, 3f);
                if (Physics.Raycast(myTransform.TransformPoint(0, 0, 1), myTransform.forward, out hit, range))
                {
                    if (hit.transform.CompareTag("Enemy"))
                    {
                        Debug.Log("Enemy " + hit.transform.name);
                    }
                }
                nextFire = Time.time + fireRate;
            }
        }
    }
}