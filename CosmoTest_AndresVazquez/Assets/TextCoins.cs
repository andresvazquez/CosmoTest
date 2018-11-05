using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCoins : MonoBehaviour {

    // Use this for initialization
    private GameObject PlayFab;
	void Start () {
        PlayFab = GameObject.FindGameObjectWithTag("PlayFab");
	}
	
	// Update is called once per frame
	void Update () {
         if (this.gameObject.GetComponent<Text>().text != PlayFab.GetComponent<DataPlayFab>().currentcoins + "")
         {
            this.gameObject.GetComponent<Text>().text = PlayFab.GetComponent<DataPlayFab>().currentcoins + "";
         }
    }
}
