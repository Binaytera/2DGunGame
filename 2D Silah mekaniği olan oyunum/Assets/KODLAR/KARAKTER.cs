using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KARAKTER : MonoBehaviour
{
	public float hız;
	public float zıplama1;
	bool zıplama2=false;
	Rigidbody2D çar;
	public static float healt;
	public Text gameover;
	public Text restart;
	public Text quıt;

	void Start()
    {
		healt = 2.3f; // Karakterin Can miktarı
		çar = GetComponent<Rigidbody2D>();
		
	}

    void Update()
    {
		float yön = Input.GetAxis("Horizontal");
		çar.velocity = new Vector2(yön * hız, çar.velocity.y);
		
		
			if (Input.GetButtonDown("Jump")&&!zıplama2) // && yerine || koyarsan sürekli zıplar
			{
			çar.velocity= new Vector2(çar.velocity.x, zıplama1);

			zıplama2 = true;

			}

			if(healt<=0)
		    {

			Destroy(gameObject);

         gameover.text = "GAME OVER";
		restart.text = "RESTART";
		quıt.text = "QUIT";
		
		     }
    }

	private void OnDestroy()
	{
		
	}

	private void OnCollisionStay2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "düşman")
		{
			healt -= 0.01f;
		}
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if(collision.gameObject.tag=="zemin")
		{ zıplama2 = false; }

		else if(collision.gameObject.tag=="platform")
		{ zıplama2 = false; }

		else if (collision.gameObject.tag == "düşman")
		{ zıplama2 = false; }

		if (collision.gameObject.tag=="düşman")
		{
			healt -= 0.01f;
		}
		
			
		
	}
	
}
