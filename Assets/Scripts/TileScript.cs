using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    TileScript tileScript;
    GameManager gameManager;

    bool canClick = true;

    [SerializeField] int spotID;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        tileScript = GetComponent<TileScript>();
        gameManager = FindObjectOfType<GameManager>();

    }

    private void Update()
    {
        if(gameManager.gameOver)
        {
            canClick = false;
        }
    }

    private void OnMouseExit()
    {
        if(canClick)
        {
            spriteRenderer.color = Color.white;
        }
    }

    private void OnMouseOver()
    {
        if (canClick)
        {
            spriteRenderer.color = Color.grey;
        }
    }

    private void OnMouseDown()
    {
        if (canClick)
        {
            canClick = false;
            if (gameManager.SelectTile(spotID))
            {
                spriteRenderer.color = Color.red;
            }
            else
            {
                spriteRenderer.color = Color.blue;
            }
            tileScript.enabled = false;
        }
    }

    public void SetID(int idInput)
    {
        spotID = idInput;
    }
}
