using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] int spotID;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter()
    {
        spriteRenderer.color = Color.grey;
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
    }

    public void SetID(int idInput)
    {
        spotID = idInput;
    }
}
