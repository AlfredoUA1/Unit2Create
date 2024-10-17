using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Variables for moving
    public Vector3 leftDirection;
    public Vector3 rightDirection;

    //Laser Prefab to shoot and location to shoot from
    public GameObject laserPrefab;
    public Vector3 laserSpot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set the variable for the laserspot equal to the player's position
        laserSpot = GetComponent<Transform>().position;

        //Code for moving the player
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Transform>().position += leftDirection;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += rightDirection;
        }

        //Spawns the laser at the variable location with zero rotation when we press space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, laserSpot, Quaternion.identity);
        }

        //If we click with the mouse, print this message
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mo");
        }
    }
}
