using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class ThrowGrenade : MonoBehaviour
    {
        public GameObject grenade;
        private Transform myTransform;

        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SpawnGrenade();
            }
        }

        void SetInitialReferences()
        {
            myTransform = transform;
        }

        void SpawnGrenade()
        {
            GameObject gameObject = Instantiate(grenade, myTransform.TransformPoint(0, 0, 0.5f), myTransform.rotation);
            Destroy(gameObject, 10f);
        }
    }
}