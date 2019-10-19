using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class WalkThroughWall : MonoBehaviour
    {
        public void SetLayerToNotSolid()
        {
            gameObject.layer = LayerMask.NameToLayer("Not Solid");

        }

        public void SetLayerToDefault()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");

        }
    }
}