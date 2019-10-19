using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private WalkThroughWall walkThroughWallScript;

        private void Start()
        {
            SetInitialReferences();
        }

        private void OnTriggerEnter(Collider other)
        {
            walkThroughWallScript.SetLayerToNotSolid();
        }

        private void OnTriggerExit(Collider other)
        {
            walkThroughWallScript.SetLayerToDefault();
        }

        private void OnTriggerStay(Collider other)
        {
        }

        private void SetInitialReferences()
        {
            if (GameObject.Find("Wall") != null)
            {
                walkThroughWallScript = GameObject.Find("Wall").GetComponent<WalkThroughWall>();
            }
        }
    }
}