using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class düşman1 : MonoBehaviour
{
	public Transform hedef;
	public static float can;
	public float hız;
	float zıp = 5f;
	Rigidbody2D ar;
	private Material matWhite;
	private Material matDefault;
	SpriteRenderer sr;


	void Start()
	{
		can = 100f;
		ar.GetComponent<Rigidbody2D>();
	
	}

	void Update()
	{

		transform.LookAt(hedef);

		transform.Rotate(new Vector3(0, -90, 0), Space.Self);

		if (Vector3.Distance(transform.position, hedef.position) > 1f)
		{
			transform.Translate(new Vector3(hız * Time.deltaTime, 0, 0));
		}

	if (can <= 0)
			{ Destroy(gameObject); }

		if (KARAKTER.healt <= 0f)
		{
			Destroy(gameObject);
		}


	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		
			can -= 1f;

		
	}









}
