using UnityEngine;

namespace Chapter1
{
    public class FindEnemies : MonoBehaviour
    {

        GameObject[] enemies;

        void Start()
        {
            SearchForEnemies();
        }

        void SearchForEnemies()
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if (enemies.Length > 0)
            {
                foreach (GameObject enemy in enemies)
                {
                    Debug.Log(enemy.name);
                    enemy.SetActive(false);
                }
            }
        }
    }
}