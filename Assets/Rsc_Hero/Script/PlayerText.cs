using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerText : MonoBehaviour
{
    public HealthSystem healthsystem;
    //public int health;
    

    void Start()
    {
        FloatingTextController.Initialize();
    }

    public virtual void TakeDamage(int amount)
    {
        //HealthSystemAttribute healthsystem = amount.gameObject.GetComponent<HealthSystemAttribute>();
        FloatingTextController.CreateFloatingText(amount.ToString(), transform);
        Debug.LogFormat("{0} was dealt {1} damage", gameObject.name, amount);
        if ((healthsystem.health -= amount) <= 0)
            Die();
    }


    public virtual void Die()
    {
        Debug.Log(gameObject.name + " has died.");
    }
}
