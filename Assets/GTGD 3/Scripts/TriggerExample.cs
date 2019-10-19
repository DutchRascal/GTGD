using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(other.name + " has entered");
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log(other.name + " has exited");

        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log(other.name + " is in trigger");
        }
    }
}