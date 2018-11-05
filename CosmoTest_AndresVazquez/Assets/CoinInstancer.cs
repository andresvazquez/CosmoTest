using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInstancer : MonoBehaviour {
    
    float Speed;
    public float speed { get { return Speed; } set { Speed = value; } }
    public float LeftLimit, RightLimit;
    public float Zorigin;
    public GameObject coinPrefab;
	// Use this for initialization
	void Start () {
        Zorigin = 25;
        LeftLimit = -3.0f;
        RightLimit = 3.0f;
        Speed = 3.65f;
        StartCoroutine(WaitToInstance());
	}

    IEnumerator WaitToInstance()
    {
        instanceObstacle();
        float time = Random.Range(3, 10);
        yield return new WaitForSeconds(time);
        StartCoroutine(WaitToInstance());
    }
	
    public void instanceObstacle()
    {
        float posx = Random.Range(LeftLimit, RightLimit + 1);
        GameObject coinClone = GameObject.Instantiate(this.coinPrefab, new Vector3(posx, .5f, Zorigin), Quaternion.identity);
        coinClone.GetComponent<ObstacleDisplacement>().Speed = Speed;
        Destroy(coinClone,35/Speed);
    }

    private void Update()
    {
        
    }
}
