using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDisplacement : MonoBehaviour {


    [Range(1, 10)]
    public float Speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.back * Speed * Time.deltaTime;
    }

}
