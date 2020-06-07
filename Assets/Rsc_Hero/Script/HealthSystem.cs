using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour
{
	public int health = 3;

	public int maxHealth;

	private int playerNumber;

    public LifeSystem ls;

    public Renderer rend;

    private void Start()
	{
		switch(gameObject.tag)
		{
			case "Player":
				playerNumber = 0;
				break;
			case "Player2":
				playerNumber = 1;
				break;
			default:
				playerNumber = -1;
				break;
		}

		maxHealth = health;
        ls = FindObjectOfType<LifeSystem>();
        rend = GetComponent<Renderer>();

    }

    public void ModifyHealth(int amount)
	{
		if(health + amount > maxHealth)
		{
            amount = maxHealth - health;
		}
		health += amount;

        
		//DEAD
		if(health <= 0)
		{
            ls.takeLife();
            StartCoroutine(Dead());
            health = maxHealth;

            if (ls.lifeCounter <= 0)
            {
                Destroy(gameObject);
                health = 0;
                ls.lifeCounter = 0;
            }
		}
    }

    IEnumerator Dead()
    {
        Debug.Log("dead");
        rend.enabled = false;
        yield return new WaitForSeconds(1);
        Debug.Log("respawn");
        rend.enabled = true;
    }
}
