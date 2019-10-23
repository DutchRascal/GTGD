using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class ThrowGrenade : MonoBehaviour
    {
        public GameObject grenadePrefab;
        private Transform myTransform;
        public float propuisionForce;

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
            GameObject gameObject = Instantiate(grenadePrefab, myTransform.TransformPoint(0, 0, 0.5f), myTransform.rotation);
            gameObject.GetComponent<Rigidbody>().AddForce(myTransform.forward * propuisionForce, ForceMode.Impulse);
            Destroy(gameObject, 10f);
        }
    }
}