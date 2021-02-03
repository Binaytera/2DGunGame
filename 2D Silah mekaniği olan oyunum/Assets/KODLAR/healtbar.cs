using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healtbar : MonoBehaviour
{

	Vector3 localScale;
    void Start()
    {
		localScale= transform.localScale;
    }

   
    void Update()
    {
		localScale.x = KARAKTER.healt;
		transform.localScale = localScale;
    }
}
