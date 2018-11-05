using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    [Range(1, 5)]
    public float Speed;
    public bool gameOver;
    public float PlayerDepth;
    [Range(.5f, 2)]
    public float speedRecover;
	// Use this for initialization
	void Start () {
        this.PlayerDepth = -8.4f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * Time.deltaTime * Speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && this.transform.position.y < 0.05f)
        {
            this.GetComponent<Animator>().SetTrigger("Jump");
            this.GetComponent<Rigidbody>().AddForce(Vector3.up*4, ForceMode.Impulse);
        }
        if(this.transform.position.z < -10.3f && !gameOver)
        {
            Debug.Log("GAME OVER");
            gameOver = true;
        }
        if(this.transform.position.z < PlayerDepth)
        {
            this.transform.position += Vector3.forward * Time.deltaTime * speedRecover;
        }
    }
}
