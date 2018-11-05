using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject GameOverText, Player, restartLevelButton;
	// Use this for initialization
	void Start () {
        if (GameOverText == null || Player ==null || restartLevelButton ==null) 
        {
            GameOverText = GameObject.FindGameObjectWithTag("GameOverText");
            Player = GameObject.FindGameObjectWithTag("Player");
            restartLevelButton = GameObject.FindGameObjectWithTag("RestartButton");
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(Player.GetComponent<PlayerControls>().gameOver && !GameOverText.activeInHierarchy)
        {
            restartLevelButton.SetActive(true);
            GameOverText.SetActive(true);
            Time.timeScale = 0.0f;
        }
	}
}
