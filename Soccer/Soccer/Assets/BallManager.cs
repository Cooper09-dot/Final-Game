using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public int Score1;
    public int Score2;
    public void OnTriggerEnter(Collider other)
    {
        //If the ball goes into the goal
        if (other.gameObject.tag == "Goal")
        {
            //teleport the ball back to it's starting point. 
            transform.position = GameObject.Find("BallPosition").transform.position;
            //Stop the ball from moving immediately after spawning.
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //add to the scoreboard. 
            Score1 += 1;
        }
        //of the ball goes into the other goal 
        if (other.gameObject.tag == "Goal2")
        {
            transform.position = GameObject.Find("BallPosition").transform.position;
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Score2 += 1;
        }
    }

        public void Update()
    {
        //changes team 1's score
            GameObject.Find("Score1").GetComponent<TextMesh>().text = Score1 + "";
        //changes team 2's score
            GameObject.Find("Score2").GetComponent<TextMesh>().text = Score2 + "";
    }
}

