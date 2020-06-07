using UnityEngine;
using System.Collections;


public class ModifyHealth : MonoBehaviour
{

	public bool destroy = false;
	public int healthChange = -1;


	private void OnCollisionEnter2D(Collision2D collisionData)
	{
		OnTriggerEnter2D(collisionData.collider);
	}

	private void OnTriggerEnter2D(Collider2D colliderData)
	{
        if(colliderData.gameObject.tag == "Player")
        {
            HealthSystem healthScript = colliderData.gameObject.GetComponent<HealthSystem>();
		    if(healthScript != null)
		    {
			    healthScript.ModifyHealth(healthChange);

			    if(destroy)
			    {
				    Destroy(this.gameObject);
			    }
		    }
        }

        if (colliderData.gameObject.tag == "Enemy")
        {
            HealthSystemEnemy healthEnemy = colliderData.gameObject.GetComponent<HealthSystemEnemy>();
            if (healthEnemy != null)
            {
                healthEnemy.ModifyHealthEnemy(healthChange);

                if (destroy)
                {
                    Destroy(this.gameObject);
                }
            }
        }

    }
}
