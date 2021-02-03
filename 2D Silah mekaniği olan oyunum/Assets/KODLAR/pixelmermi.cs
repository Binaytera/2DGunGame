using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pixelmermi : MonoBehaviour
{

	public float hız;

	Rigidbody2D rb2d;
	void Start()
    {
		//rb2d = GetComponent<Rigidbody2D>();
	}


	private void Update()
	{
		transform.Translate(transform.up * hız * Time.deltaTime);
		//rb2d.velocity = new Vector2(30, 0);
	}

   

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
		if (collision.gameObject.CompareTag("düşman"))
		{ Destroy(gameObject); }
		if (collision.gameObject.CompareTag("platform"))
		{ Destroy(gameObject); }
		 if (collision.gameObject.CompareTag("zemin"))
		{ Destroy(gameObject); }
		 if (collision.gameObject.CompareTag("Finish"))
		{ Destroy(gameObject); }
	}

	
}
