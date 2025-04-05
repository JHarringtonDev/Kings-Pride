using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilePlayer : MonoBehaviour
{

    Vector3 playerDestination;
    float movementProgress = 1;
    [SerializeField] float moveSpeed;

    private void FixedUpdate()
    {
        if (movementProgress < 1)
        {
            transform.position = Vector3.Lerp(transform.position, playerDestination, movementProgress);
            movementProgress += moveSpeed;
        }
    }

    public void MoveToSpot(Vector3 MovementLocation)
    {
        playerDestination = MovementLocation;
        movementProgress = 0;
    } 
}
