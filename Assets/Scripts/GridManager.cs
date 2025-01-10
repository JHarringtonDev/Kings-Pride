using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] int gridWidth;
    [SerializeField] int gridHeight;
    [SerializeField] GameObject tilePrefab;

    private void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for(int x = 0; x < gridWidth; x++)
        {
            for( int y = 0; y < gridHeight; y++)
            {
                var generatedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                generatedTile.name = $"Tile {x},{y}";
            }
        }
    }
}
