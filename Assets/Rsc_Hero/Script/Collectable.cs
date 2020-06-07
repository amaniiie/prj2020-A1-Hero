using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour
{
	public bool destroy = false;
	public int pointsWorth = 0;

	private void Start() {
		ScoreScript.scoreValue = 0;
	}

	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		ScoreScript.scoreValue += pointsWorth;
		if(destroy){
			Destroy(gameObject);
		}	
	}
}
