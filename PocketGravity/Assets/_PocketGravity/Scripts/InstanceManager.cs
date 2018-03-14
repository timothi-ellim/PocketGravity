using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.iOS;

public class InstanceManager : MonoBehaviour {

	public GameObject startMenu;
	public GameObject searchUI;
	public GameObject gameUI;
	public GameObject gameOverUI;
	public GameObject reticle;

	public bool gameStarted = false;
	private bool gameOverState = false;

	public GameObject PGM;
	public GameObject HCP;

	public Text ScoreText;
	public Text TimerText;

	public AudioManager AM;

	private int score; 
	private float startTime;

	public float timer = 300;


	void Awake(){
		PGM.SetActive (false);
		HCP.SetActive (false);
		gameUI.SetActive (false);
	}

	void Start(){
		AM = GameObject.FindGameObjectWithTag ("AM").GetComponent<AudioManager> ();
		score = 0;
		ScoreText.text = score.ToString();
	}

	void Update(){
		if (gameStarted) {
			if (timer < 0) {
				timer = 0;
				GameOver ();
			}
			timer -= Time.deltaTime;
			TimerText.text = timer.ToString ("f1");
		}
	}

	public void StartGame(){
		startMenu.SetActive (false);
		gameStarted = true;
		HCP.SetActive (true);
		searchUI.SetActive (true);
		AM.Play(0);
		//gameUI.SetActive (true);
	}

	public void StartThisGame(){
		searchUI.SetActive (false);
		PGM.SetActive (true);
		gameUI.SetActive (true);
		AM.Play (1);
	}

	private void GameOver(){
		gameOverState = true;
		reticle.SetActive (false);
		PGM.SetActive (false);
		HCP.SetActive (false);
		gameOverUI.SetActive (true);
		AM.Play (5);
	}

	public void Restart(){
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.buildIndex);
	}

		
	public void AddScore(){
		if (!gameOverState) {  
			score += 100;	
			ScoreText.text = score.ToString ();
			AM.Play (2);
		}
	}

	public void AddScoreShoot(){
		if (!gameOverState) {  
			score += 1;	
			ScoreText.text = score.ToString ();
			AM.Play (3);
		}
	}

}
