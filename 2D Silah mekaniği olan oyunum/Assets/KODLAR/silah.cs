using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silah : MonoBehaviour
{
	Object bulletRef;
	public float offset;
	public GameObject project;
	public Transform point;
	private float ateş1;
	public float ateş2;
	void Start()
	{
		bulletRef = Resources.Load("MERMİ");
	}


	private void Update()
	{
		if (ateş1<=0)
		{
         if (Input.GetButtonDown("Fire1"))
		{
			Instantiate(project, point.position, transform.rotation);
				ateş1 = ateş2;
		}
		}
		else
		{ ateş1 -= Time.deltaTime; }
		
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
		
	}
}
