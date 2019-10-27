using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{

    public class GameManagerEventMaster : MonoBehaviour
    {
        public delegate void GeneralEvent();
        public event GeneralEvent myGeneralEvent;

        public void CallMyGeneralEvent()
        {
            if (myGeneralEvent != null)
            {
                myGeneralEvent();
            }
        }
    }
}