using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUnlockables : MonoBehaviour {
    
    public GameObject hamUnlock, rubyUnlock, runeUnlock;
    private GameObject playFab;
    void OnEnable () {
        playFab = GameObject.FindGameObjectWithTag("PlayFab");
    }
	
	// Update is called once per frame
	void Update () {
        if (playFab.GetComponent<DataPlayFab>().ham && !hamUnlock.activeInHierarchy)
        {
            hamUnlock.SetActive(true);
        }

        if (playFab.GetComponent<DataPlayFab>().ruby && !rubyUnlock.activeInHierarchy)
        {
            rubyUnlock.SetActive(true);
        }

        if (playFab.GetComponent<DataPlayFab>().rune && !runeUnlock.activeInHierarchy)
        {
            runeUnlock.SetActive(true);
        }
    }
}
