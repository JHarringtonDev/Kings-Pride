using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tileClick : MonoBehaviour
{
    Image tileImage;
    tileManager squareManager;
    tilePlayer playerTile;

    bool tilePlayed;

    private void Start()
    {
        tileImage = GetComponent<Image>();
        squareManager = FindObjectOfType<tileManager>();
        playerTile = FindObjectOfType<tilePlayer>();
    }

    public void HandlePlayerMovement()
    {
        playerTile.MoveToSpot(transform.position);
    }

    //public void changeTile()
    //{
    //    if(squareManager != null && !tilePlayed)
    //    {
    //    Debug.Log("clicked");
    //        if(squareManager.changeTurn() == true)
    //        {
    //            tileImage.color = Color.blue;
    //        }
    //        else
    //        {
    //            tileImage.color = Color.red;
    //        }
    //        tilePlayed = true;
    //    }
    //}
    //
    //public void showHoverColor()
    //{
    //    if(!tilePlayed)
    //    {
    //        tileImage.color = Color.gray;
    //    }
    //}
    //
    //public void RevertTile()
    //{
    //
    //     if(!tilePlayed)
    //    {
    //        tileImage.color = Color.white;
    //    }
    //}
}
