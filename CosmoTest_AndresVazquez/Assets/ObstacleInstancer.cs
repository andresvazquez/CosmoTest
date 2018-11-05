using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstancer : MonoBehaviour {

    [Range(1, 10)]
    public float Speed;
    public float LeftLimit, RightLimit;
    public float Zorigin;
    public GameObject[] obstacles;
    float prevSpeed;
    public GameObject coinInstancer;
    // Use this for initialization
    void Start () {
        Speed = 3.65f;
        LeftLimit = -2.5f;
        RightLimit = 2.5f;
        Zorigin = 25f;
        prevSpeed = Speed;
        Shader.SetGlobalFloat("_Speed", Speed * 2.73973f);
        StartCoroutine(WaitToInstance());
	}

    IEnumerator WaitToInstance()
    {
        instanceObstacle();
        float adaptWithTime = 6 / (1 + (0.3f * (Speed - 1)));
        float time = Random.Range(adaptWithTime, adaptWithTime+4);
        yield return new WaitForSeconds(time);
        StartCoroutine(WaitToInstance());
    }
	
    public void instanceObstacle()
    {
        int i = Random.Range(1, obstacles.Length);
        float posx = Random.Range(LeftLimit, RightLimit + 1);
        GameObject obstacleClone;
        if (this.obstacles[i].name != "Obstacle4")
        {
            obstacleClone = GameObject.Instantiate(this.obstacles[i], new Vector3(posx, 2f, Zorigin), Quaternion.identity);
        }
        else
        {
            obstacleClone = GameObject.Instantiate(this.obstacles[i], new Vector3(0, 2f, Zorigin), Quaternion.identity);
        }
        obstacleClone.GetComponent<ObstacleDisplacement>().Speed = Speed;
        Destroy(obstacleClone,35/Speed);
    }

    private void Update()
    {
        if (Speed != prevSpeed)
        {
            Shader.SetGlobalFloat("_Speed", Speed * 2.73973f);
            prevSpeed = Speed;
            coinInstancer.GetComponent<CoinInstancer>().speed = Speed;
            searchAndDelete();
        }
    }

    public void searchAndDelete()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");

        if (obstacles.Length >= 1 || coins.Length >= 1)
        {
            for (int i = 0; i < obstacles.Length; i++)
            {
                Destroy(obstacles[i]);
            }
            for (int i = 0; i < coins.Length; i++)
            {
                Destroy(coins[i]);
            }
        }
    }
}
