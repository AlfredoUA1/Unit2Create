using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserMove : MonoBehaviour
{
    //This script makes the laser go upward
    //Variable for laser direction
    public Vector3 upDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make the laser go up every frame
        GetComponent<Transform>().position += upDirection;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //If the laser hits the invader, destroy the invader and the laser
        if (collision.gameObject.tag == "Invader")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
