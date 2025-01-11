using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool redsTurn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetCurrentTurn()
    {
        bool currentTurn = redsTurn;
        changeTurn();

        return currentTurn;
    }

    void changeTurn()
    {
        if(redsTurn)
        {
            redsTurn = false;
        }
        else
        {
            redsTurn = true;
        }
    }
}
