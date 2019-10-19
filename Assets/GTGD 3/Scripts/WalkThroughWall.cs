using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class WalkThroughWall : MonoBehaviour
    {
        private void OnEnable()
        {
            gameObject.layer = LayerMask.NameToLayer("Not Solid");
        }

        private void OnDisable()
        {
            gameObject.layer = LayerMask.NameToLayer("Default");
        }
    }
}