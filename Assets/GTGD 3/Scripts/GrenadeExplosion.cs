using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class GrenadeExplosion : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log(collision.contacts[0].point.ToString());
            Destroy(gameObject);
        }
    }
}