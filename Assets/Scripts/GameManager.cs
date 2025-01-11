using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] bool redsTurn;
    bool currentTurn;

    public bool gameOver;
    List<int> blueTiles = new List<int>();
    List<int> redTiles = new List<int>();
    List<int> checkList;

    public bool SelectTile(int spotID)
    {
        currentTurn = redsTurn;

        if(redsTurn)
        {
            redTiles.Add(spotID);
            redsTurn = false;
            checkList = redTiles;
        }
        else
        {
            blueTiles.Add(spotID);
            redsTurn = true;
            checkList = blueTiles;
        }
        CheckWin();

        return currentTurn;
    }

    void CheckWin()
    {
        if (
            //Horizontal
            (checkList.Contains(1) && checkList.Contains(4) && checkList.Contains(7)) || 
            (checkList.Contains(2) && checkList.Contains(5) && checkList.Contains(8)) || 
            (checkList.Contains(3) && checkList.Contains(6) && checkList.Contains(9)) ||
            
            //Vertical
            (checkList.Contains(1) && checkList.Contains(2) && checkList.Contains(3)) ||
            (checkList.Contains(4) && checkList.Contains(5) && checkList.Contains(6)) ||
            (checkList.Contains(7) && checkList.Contains(8) && checkList.Contains(9)) ||

            //Diagonal
            (checkList.Contains(3) && checkList.Contains(5) && checkList.Contains(7)) ||
            (checkList.Contains(1) && checkList.Contains(5) && checkList.Contains(9))
            )
        {
            ReportWin();
        }
       
        else if(redTiles.Count + blueTiles.Count == 9)
        {
            ReportTie();
        }
    }

    void ReportWin()
    {
        gameOver = true;

        if (currentTurn == true)
        {
            Debug.Log("Red Player Wins");
        } 
        else if(currentTurn == false)
        {
            Debug.Log("Blue Player Wins");
        }
    }
    
    void ReportTie()
    {
        gameOver = true;
        Debug.Log("The game has Tied");
    }
}
