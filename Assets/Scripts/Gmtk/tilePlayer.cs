using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilePlayer : MonoBehaviour
{

    public void MoveToSpot(Vector3 MovementLocation)
    {
        for (float i = 0; i <1; i+= 0.00002f)
        {
            transform.position = Vector3.Lerp(transform.position, MovementLocation, i);
        }
    } 
}
