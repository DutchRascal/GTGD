using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
    public class Spawner : MonoBehaviour
    {
        public int numberOfEnemies;
        public GameObject objectToSpawn;
        private float spawnRadius = 5;
        private Vector3 spawnPosition;
        private GameManagerEventMaster eventMasterScript;

        private void OnEnable()
        {
            SetInitialReferences();
            eventMasterScript.myGeneralEvent += SpawnObject;
        }

        private void OnDisable()
        {
            eventMasterScript.myGeneralEvent -= SpawnObject;
        }

        void SpawnObject()
        {
            for (int i = 0; i < numberOfEnemies; i++)
            {
                spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
                Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
            }
        }

        void SetInitialReferences()
        {
            eventMasterScript = GameObject.Find("GameManager").GetComponent<GameManagerEventMaster>();
        }
    }
}