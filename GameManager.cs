using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //This script spawns the enemy prefabs (make sure to properly insert numbers in the inspector)
    //Variable for a list of invaders
    //This is a list because we are using multiple different invader prefabs
    //If we only are using one type of enemy, a list is not needed
    public GameObject[] invaders;

    //Variable for a list of locations and timer
    public Vector3[] invaderLocations;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Start counting time
        timer += Time.deltaTime;

        //After 3 seconds...
        if (timer >= 3)
        {
            //For each invader in our list of invaders...
            for (int i = 0; i < invaders.Length; i++)
            {
                //Spawn an invader at a location
                Instantiate(invaders[i], invaderLocations[i], Quaternion.identity);
            }

            //Reset timer
            timer = 0;
        }
        
    }
}
