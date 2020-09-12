using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Transform target;

    public int maxHealth = 5;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        // move towards player

        if (currentHealth <= 0)
            GameManager.Instance.enemyManager.KillEnemy(gameObject);
    }

    public void DealDamage(int damage)
    {
        currentHealth -= damage;
    }

}
