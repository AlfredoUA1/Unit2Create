using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    //This script makes the enemy move down every few seconds
    //Variables for a timer to count and downward movement
    public float timer;
    public Vector3 downDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Start the timer
        timer += Time.deltaTime;

        //After 1.5 seconds, push the enemy down a bit then reset the timer (stops the movement)
        if (timer >= 1.5)
        {
            GetComponent<Transform>().position += downDirection;
            timer = 0;
        }
    }

    //Stretch Goal 1
    //If the enemy touches the player, destroy the player and print message
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            Debug.Log("You Lose");
        }

        //Stretch Goal 2
        //If enemy touches bottom of the screen (invisible gameobject) print message
        if (collision.gameObject.tag == "Bottom")
        {
            Debug.Log("You Lose");
        }
    }
}
