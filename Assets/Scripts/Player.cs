using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    public int maxHealth = 100;
    public int currentHealth;

    float movement;
    Shovel shovel;

    // Start is called before the first frame update
    void Start()
    {
        shovel = GetComponentInChildren<Shovel>();

        currentHealth = maxHealth;
    }

    void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Horizontal");
        if (movement != 0)
            Move();

        if (Input.GetMouseButtonDown(0))
            Attack();

        if (Input.GetMouseButtonDown(1))
            Dig();
        
    }

    private void Dig()
    {
        StartCoroutine(shovel.Dig());
    }

    private void Attack()
    {
        StartCoroutine(shovel.Attack());
    }

    void Move()
    {

        if (movement > 0)
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        else
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        transform.position = Vector2.MoveTowards(transform.position,
            new Vector2(transform.position.x + movement, transform.position.y),
            speed * Time.deltaTime);

        
    }
}
