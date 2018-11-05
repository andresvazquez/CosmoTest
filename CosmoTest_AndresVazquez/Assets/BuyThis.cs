using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyThis : MonoBehaviour {

    // Use this for initialization
    public int price;
    private GameObject PlayFab;
    private int currentcoins;
	void OnEnable () {
        PlayFab= GameObject.FindGameObjectWithTag("PlayFab");
        currentcoins = PlayFab.GetComponent<DataPlayFab>().currentcoins;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Buy()
    {
        if (price <= currentcoins)
        {
            PlayFab.GetComponent<DataPlayFab>().currentcoins -= price;
            PlayFab.GetComponent<SetCoins>().setCoinsChange();
            if (this.gameObject.name == "Ruby") {
                PlayFab.GetComponent<SetCoins>().UnlockRuby();
                PlayFab.GetComponent<DataPlayFab>().ruby = true;
            }
            if (this.gameObject.name == "Ham")
            {
                PlayFab.GetComponent<SetCoins>().UnlockHam();
                PlayFab.GetComponent<DataPlayFab>().ham = true;
            }
            if (this.gameObject.name == "Rune")
            {
                PlayFab.GetComponent<SetCoins>().UnlockRune();
                PlayFab.GetComponent<DataPlayFab>().rune = true;
            }
        }
    }
}
