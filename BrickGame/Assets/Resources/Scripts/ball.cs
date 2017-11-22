using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    Paddle paddle;
    Vector3 paddleBallPosDiff;
    bool gamestarted = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle> ();
        paddleBallPosDiff = this.transform.position - paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (!gamestarted)
        {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gamestarted) 
        {
            gamestarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f) ;
        }

        }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gamestarted)// if(gamestarted == true)
        {
            //GetComponent<AudioSource>().Play();
        }
    }
}
