using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public float speed = 1f;

	private Rigidbody2D ballRigedBody;
	// Use this for initialization
	void Start () {
		ballRigedBody = GetComponent<Rigidbody2D>();
		ballRigedBody.velocity = new Vector2(
			-0.5f,
			speed
		);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Limit")
		{
			if (other.transform.position.y > transform.position.y && ballRigedBody.velocity.y >0)
			{
				//collided with  the top limit.
				ballRigedBody.velocity = new Vector2(
					ballRigedBody.velocity.x,
					-ballRigedBody.velocity.y
				);
			}
			else if(other.transform.position.y < transform.position.y && ballRigedBody.velocity.y <0)
			{
				//collided with the bottom limit.
				ballRigedBody.velocity = new Vector2(
					ballRigedBody.velocity.x,
					-ballRigedBody.velocity.y
				);
			}
		}else if (other.tag == "Paddle")
		{
			if (other.transform.position.x < transform.position.x && ballRigedBody.velocity.x < 0) 
			{
				ballRigedBody.velocity = new Vector2(
					-ballRigedBody.velocity.x,
					ballRigedBody.velocity.y
				);
			}else if (other.transform.position.x>transform.position.x && ballRigedBody.velocity.x > 0) 
			{
				ballRigedBody.velocity = new Vector2(
					-ballRigedBody.velocity.x,
					ballRigedBody.velocity.y
				);
			}
			
		}
	}
}
