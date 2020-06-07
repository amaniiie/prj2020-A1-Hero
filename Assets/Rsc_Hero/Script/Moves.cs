using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Moves : MonoBehaviour
{
    public float speed = 10.4f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Update() {
		Vector3 pos = transform.position;
		if (Input.GetKey("w"))
		{
			pos.y += speed * Time.deltaTime;
		}
		if (Input.GetKey("s"))
		{
			pos.y -= speed * Time.deltaTime;
		}
		if (Input.GetKey("d"))
		{
			pos.x += speed * Time.deltaTime;
		}
		if (Input.GetKey("a"))
		{
			pos.x -= speed * Time.deltaTime;
		}
		transform.position = pos;
	}
	
    /*private void FixedUpdate()
    {
        rb.velocity = new Vector2(pos.x, pos.y);
    }*/

}