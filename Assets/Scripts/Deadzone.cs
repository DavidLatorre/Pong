using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Deadzone : MonoBehaviour {

	public Text scorePlayerText;
	public Text scoreEnemyText;

	int scorePlayerQuantity;
	int scoreEnemyQuantity;

	public SceneChanger sceneChanger;

	public AudioSource pointAudio; 

	private void OnTriggerEnter2D(Collider2D ball)
	{	
		if(gameObject.tag == "Left")
		{	
			scoreEnemyQuantity++;
			UpdateScoreLabel(scoreEnemyText, scoreEnemyQuantity);
			

		}else if(gameObject.CompareTag("Right"))
		{
			scorePlayerQuantity++;
			UpdateScoreLabel(scorePlayerText, scorePlayerQuantity);
		}

		ball.GetComponent<BallBehaviour>().gameStarted = false;
		CheckScore();
		pointAudio.Play();

	}

	void CheckScore()
	{
		if(scorePlayerQuantity >=3)
		{
			sceneChanger.ChangeSceneTo("WinScene");
		}
		else if (scoreEnemyQuantity >=3)
		{
			sceneChanger.ChangeSceneTo("LoseScene");
		}

	}

	void UpdateScoreLabel(Text label, int score)
	{
		label.text = score.ToString();
	}
}
