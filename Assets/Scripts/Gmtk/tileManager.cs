using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    bool redTurn; 

    public bool changeTurn()
    {
        if (redTurn)
        {
            redTurn = false;
        }
        else
        {
            redTurn = true;
        }
        return redTurn;
    }
}
