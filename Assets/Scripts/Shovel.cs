using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shovel : MonoBehaviour
{

    public int damage = 1;

    Collider2D coll;
    Animator animator;

    void Start()
    {
        coll = GetComponent<Collider2D>();
        animator = GetComponentInChildren<Animator>();
        coll.enabled = false;
    }

    void Update()
    {
        
    }

    public IEnumerator Dig()
    {
        coll.enabled = true;
        animator.SetTrigger("dig");
        yield return new WaitForSeconds(1f);
        coll.enabled = false;
    }

    public IEnumerator Attack()
    {
        coll.enabled = true;
        animator.SetTrigger("attack");
        yield return new WaitForSeconds(1f);
        coll.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Root")
        {
            collision.GetComponent<Root>().DealDamage(damage);
            Debug.Log("Hit root");
        }
        else if (collision.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().DealDamage(damage);
            Debug.Log("Hit enemy");
        }

    }


}
