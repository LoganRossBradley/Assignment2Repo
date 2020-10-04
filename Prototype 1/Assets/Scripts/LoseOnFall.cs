/*
 * Logan ross
 * assignment 2
 * Tell the player they loose if they fall off road
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            UpdateScore.gameOver = true;
        }
    }
}
