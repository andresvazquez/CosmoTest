using PlayFab;
using PlayFab.ClientModels;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPlayFab : MonoBehaviour {
    
    public int currentcoins;
    public bool ham, ruby, rune;
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
       

        
    }
    public void GetUserData()
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest()
        {   
            Keys = null
        }, result => {
            Debug.Log("Got user data:");
            if (result.Data == null || !result.Data.ContainsKey("Coins"))
            {
                Debug.Log("No Coins");
                this.GetComponent<SetCoins>().InitializeData();
                return;
            }
            else
            {
                Debug.Log("Coins: " + result.Data["Coins"].Value);
                currentcoins = int.Parse(result.Data["Coins"].Value);
            }
            if (result.Data == null || !result.Data.ContainsKey("Ruby"))
            {
                Debug.Log("No Ruby");
            }
            else
            {
                Debug.Log("Ruby: " + result.Data["Ruby"].Value);
                if (result.Data["Ruby"].Value == "Unlocked")
                {
                    ruby = true;
                }
            }
            if (result.Data == null || !result.Data.ContainsKey("Rune")) Debug.Log("No Rune");
            else
            {
                Debug.Log("Rune: " + result.Data["Rune"].Value);
                if (result.Data["Rune"].Value == "Unlocked")
                {
                    rune = true;
                }
            }
            if (result.Data == null || !result.Data.ContainsKey("Ham")) Debug.Log("No Ham");
            else
            {
                Debug.Log("Ham: " + result.Data["Ham"].Value);
                if (result.Data["Ham"].Value == "Unlocked")
                {
                    ham = true;
                }
            }

        }, (error) => {
            Debug.Log("Got error retrieving user data:");
            Debug.Log(error.GenerateErrorReport());
        });
    }


}
