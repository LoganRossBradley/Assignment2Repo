/* 
 * (Logan Ross) 
 * (Assignment 2) 
 * (makes it so you gain points when passing in between the barriers) 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneHit : MonoBehaviour
{

    public bool triggered;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered && !UpdateScoreX.gameOver)
        {
            triggered = true;
            UpdateScoreX.currentScore++;
        }
    }
}
