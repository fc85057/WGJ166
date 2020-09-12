using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : MonoBehaviour
{

    public int maxHealth;
    public int currentHealth;
    public float spawnDelay = 5f;

    void Start()
    {
        currentHealth = maxHealth;
        StartCoroutine("DevelopCountdown");
    }

    void Update()
    {
        if (currentHealth <= 0)
            GameManager.Instance.enemyManager.KillRoot(gameObject);
    }

    public void DealDamage(int damage)
    {
        currentHealth -= damage;
    }

    IEnumerator DevelopCountdown()
    {
        yield return new WaitForSeconds(spawnDelay);
        DevelopIntoEnemy();
    }

    void DevelopIntoEnemy()
    {
        GameManager.Instance.enemyManager.SpawnEnemy(gameObject);
    }

}
