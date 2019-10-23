using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class GrenadeExplosion : MonoBehaviour
    {

        private Collider[] hitColliders;
        public float blastRadius;

        private void OnCollisionEnter(Collision collision)
        {
            ExplosionWork(collision.contacts[0].point);
            Destroy(gameObject);
        }

        private void ExplosionWork(Vector3 explosionPoint)
        {
            hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius);
            foreach (Collider hitCollider in hitColliders)
            {
                Debug.Log(hitCollider.gameObject.name);
            }
        }
    }
}