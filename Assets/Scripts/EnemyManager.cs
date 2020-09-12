using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    public GameObject root;
    public GameObject enemy;
    public Transform spawnPoint;
    public float yOffset = 3.5f;

    List<GameObject> roots;
    List<GameObject> enemies;

    void Start()
    {
        roots = new List<GameObject>();
        enemies = new List<GameObject>();

        SpawnRoot();
    }

    private void SpawnRoot()
    {
        GameObject newRoot = Instantiate(root, new Vector3(spawnPoint.transform.position.x,
            spawnPoint.transform.position.y - yOffset, transform.position.y), Quaternion.identity);
        roots.Add(newRoot);
    }

    public void SpawnEnemy(GameObject rootGameObject)
    {
        roots.Remove(rootGameObject);
        GameObject newEnemy = Instantiate(enemy, spawnPoint);
        enemies.Add(newEnemy);
        Destroy(rootGameObject);
    }


    public void KillRoot(GameObject rootGameObject)
    {
        Debug.Log(roots.Count);
        roots.Remove(rootGameObject);
        Destroy(rootGameObject);
        Debug.Log(roots.Count);
    }

    public void KillEnemy(GameObject enemyGameObject)
    {
        Debug.Log(enemies.Count);
        enemies.Remove(enemyGameObject);
        Destroy(enemyGameObject);
        Debug.Log(enemies.Count);
    }

}
