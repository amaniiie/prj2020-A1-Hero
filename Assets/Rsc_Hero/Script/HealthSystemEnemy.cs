using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystemEnemy : MonoBehaviour
{
    public int health = 3;

    public int maxHealth;

    //private int playerNumber;

    //public LifeSystemEnemy ls;

    //public Renderer rend;

    private void Start()
    {
        if (gameObject.tag == "Enemy")
        {
            maxHealth = health;
            //ls = FindObjectOfType<LifeSystemEnemy>();
            //rend = GetComponent<Renderer>();
        }
    }

    public void ModifyHealthEnemy(int amount)
    {
        if (health + amount > maxHealth)
        {
            amount = maxHealth - health;
        }
        health += amount;


        //DEAD
        if (health <= 0)
        {
            //ls.takeLifeEnemy();
            //StartCoroutine(Dead());
            health = maxHealth;

            //if (ls.lifeCounter <= 0)
            //{
                Destroy(gameObject);
                health = 0;
                //ls.lifeCounter = 0;
            //}
        }
    }

    //IEnumerator Dead()
    //{
    //    Debug.Log("dead");
    //    rend.enabled = false;
    //    yield return new WaitForSeconds(1);
    //    Debug.Log("respawn");
    //    rend.enabled = true;
    //}
}
