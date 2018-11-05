using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    // Use this for initialization
    private bool isPaused;
    private GameObject Player;
    public Sprite pause, play;
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseOrPlayGame()
    {
        if (!Player.GetComponent<PlayerControls>().gameOver)
        {
            if (!isPaused)
            {
                Time.timeScale = 0.0f;
                this.GetComponent<Image>().sprite = play;
            }
            else
            {
                Time.timeScale = 1.0f;
                this.GetComponent<Image>().sprite = pause;
            }
            isPaused = !isPaused;
        }
    }
}
