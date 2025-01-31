using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
 private float topBound = 30;
  private float lowerBound = -10;

    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if(transform.position.z > topBound){
            Destroy(gameObject);
        } else if(transform.position.z < lowerBound){
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}