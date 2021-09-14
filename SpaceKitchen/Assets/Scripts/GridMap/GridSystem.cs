using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class GridSystem 
{
    private int gridWidth;
    private int gridHeight;
    private float gridCellSize;
    private int[,] gridArray;
    private TextMesh[,] textArray;

    public GridSystem(int gridWidthIN, int gridHeightIN, float gridCellSizeIN)
    {
        this.gridWidth = gridWidthIN;
        this.gridHeight = gridHeightIN;
        this.gridCellSize = gridCellSizeIN;

        gridArray = new int[gridWidth, gridHeight];
        textArray = new TextMesh[gridWidth, gridHeight];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                textArray[x,y] = Utils.Utils.CreateWorldText(gridArray[x, y].ToString(), null, GetWorldPosition(x, y) + new Vector3 (gridCellSize,gridCellSize)*.5f, 20, Color.white, TextAnchor.MiddleCenter);

                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1), Color.white, 100f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y), Color.white, 100f);
            }
        }
        Debug.DrawLine(GetWorldPosition(0, gridHeight), GetWorldPosition(gridWidth, gridHeight), Color.white, 100f);
        Debug.DrawLine(GetWorldPosition(gridWidth, 0), GetWorldPosition(gridWidth, gridHeight), Color.white, 100f);

        SetGridValue(2, 1, 56);
    }

    private Vector3 GetWorldPosition(int x , int y)
    {
        return new Vector3(x, y) * gridCellSize;
    }

    private void GetXY(Vector3 worldPosition, out int XValue, out int YValue)
    {
        XValue = Mathf.FloorToInt(worldPosition.x / gridCellSize);
        YValue = Mathf.FloorToInt(worldPosition.y / gridCellSize);
    }

    public void SetGridValue(int x, int y, int value)
    {
        if(x>= 0 && y>=0 && x<gridWidth && y < gridHeight)
        {
            gridArray[x, y] = value;
            textArray[x, y].text = gridArray[x, y].ToString();
        }
        
    }

    public void SetGridValue(Vector3 worldPos, int value)
    {
        int XValue, YValue;
        GetXY(worldPos, out XValue, out YValue);
        SetGridValue(XValue, YValue, value);
    }
}
