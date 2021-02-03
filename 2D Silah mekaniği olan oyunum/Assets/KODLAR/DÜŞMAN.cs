using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DÜŞMAN : MonoBehaviour
{
	public Transform hedef;
	public static float can;
	public float hız;
    float zıp=5f;
	Rigidbody2D ar;

	

	void Start()
	{
		can = 100f;
		ar.GetComponent<Rigidbody2D>();
	}

	void Update()
	{

		transform.LookAt(hedef);

		transform.Rotate(new Vector3(0,-90,0), Space.Self);

		if (Vector3.Distance(transform.position, hedef.position) > 1f)
		{
			transform.Translate(new Vector3(hız * Time.deltaTime, 0, 0));
		}

		// if (Input.GetButtonDown("Jump") || !zıp2) 
		// {
	    // ar.velocity = new Vector2(ar.velocity.x, zıp);
		// }

		if(KARAKTER.healt<=0f)
		{
			Destroy(gameObject);
		}

		if (can <= 0)
		{
			Destroy(gameObject);
		    
	
		}
	   else	if (can<=20)
		{

		}

	}
	
	

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "mermi")
		{
			can -= 0.5f;
		}
	}

	// private void OnCollisionEnter2D(Collision2D collision)  // DAHA YAPILMADI
	// {

	// if (collision.gameObject.tag == "platform")
	//	{


	//	}
	//  } 
}