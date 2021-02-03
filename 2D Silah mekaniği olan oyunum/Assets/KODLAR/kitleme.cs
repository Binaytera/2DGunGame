using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class kitleme : MonoBehaviour
{
	public GameObject çar;
	Vector3 mesafe;
	void Start()
	{
		mesafe = transform.position - çar.transform.position;

	}
	void Update()
	{
		
		transform.position = çar.transform.position;
		
	}
}
