using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	private Vector3 posA;

	private Vector3 posB;

	private Vector3 nexPos;

	[SerializeField]
	private float hız;

	[SerializeField]
	private Transform TransformA;

	[SerializeField]
	private Transform transformB;

	void Start()
	{
		posA = TransformA.localPosition;
		posB = transformB.localPosition;
		nexPos = posB;
	}

	void Update()
	{
		Move();
		
	}

	private void Move()
	{
		TransformA.localPosition = Vector3.MoveTowards(TransformA.localPosition, nexPos, hız * Time.deltaTime);
		
		if(Vector3.Distance(TransformA.localPosition,nexPos)<=0.1)
		{
			ChangeDestination();
		}
	}

	private void ChangeDestination()
	{
		nexPos = nexPos != posA ? posA : posB;
	}
}

