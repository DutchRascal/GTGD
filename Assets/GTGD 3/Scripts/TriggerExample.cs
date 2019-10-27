using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class TriggerExample : MonoBehaviour
    {
        private WalkThroughWall walkThroughWallScript;
        private GameManagerEventMaster eventMasterScript;

        private void Start()
        {
            SetInitialReferences();
        }

        private void OnTriggerEnter(Collider other)
        {
            walkThroughWallScript.SetLayerToNotSolid();
            eventMasterScript.CallMyGeneralEvent();
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
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManagerEventMaster>();
        }
    }
}