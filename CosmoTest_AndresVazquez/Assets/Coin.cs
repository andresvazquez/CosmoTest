using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {

    private GameObject playFabData;
	// Use this for initialization
	void Start () {
        playFabData = GameObject.FindGameObjectWithTag("PlayFab");
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            playFabData.GetComponent<DataPlayFab>().currentcoins += 1;
            Destroy(this.gameObject);
        }
        if(collision.transform.tag == "Obstacle")
        {
            this.transform.position += Vector3.back;
        }
    }
}
