using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAvailable : MonoBehaviour {

    public GameObject HamItem, RuneItem, RubyItem;
    GameObject playFab;
	// Use this for initialization
	void Start () {
        playFab = GameObject.FindGameObjectWithTag("PlayFab");
	}
	
	// Update is called once per frame
	void Update () {
        if (playFab.GetComponent<DataPlayFab>().ham && !HamItem.activeInHierarchy)
        {
            HamItem.SetActive(true);
        }

        if (playFab.GetComponent<DataPlayFab>().ruby && !RubyItem.activeInHierarchy)
        {
            RubyItem.SetActive(true);
        }

        if (playFab.GetComponent<DataPlayFab>().rune && !RuneItem.activeInHierarchy)
        {
            RuneItem.SetActive(true);
        }
    }
}
