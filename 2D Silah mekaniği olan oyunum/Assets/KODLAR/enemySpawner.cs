using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
	public GameObject enemy;
	float randX;
	Vector2 whereToSpawn;
	public float spawnRate = 2f;
	float nextSpawn = 0.0f;
    void Start()
    {
		
	}


	private void OnDestroy()
	{
        if(Time.time>nextSpawn)
		{
			
		nextSpawn = Time.time + spawnRate;
					
        randX = Random.Range(-25f,25f);

		whereToSpawn = new Vector2(randX, transform.position.y);

		Instantiate(enemy, whereToSpawn, Quaternion.identity);
			
				
			
			
			
		}
	}
   
        
    
}
