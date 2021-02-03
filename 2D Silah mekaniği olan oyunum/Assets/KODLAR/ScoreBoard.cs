using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{

	public Transform çar;
	public Text skor;
	public float scoreAmount;
	public float snPuan;
	public static int highscore;
	public static int score;
	public Text highScore;
    void Start()
    {
		scoreAmount = 0f;
		snPuan = 2f;
	

	}

    void Update()
    {
		skor.text = "SKOR " + (int)scoreAmount;
		scoreAmount += snPuan * Time.deltaTime;
		if(KARAKTER.healt<=0)
		{
			Destroy(gameObject);
		}
		
	 
	}

	private void OnDestroy()
	{

		highScore.text = " SKORUNUZ => " + (int)scoreAmount;
		

	}
}
