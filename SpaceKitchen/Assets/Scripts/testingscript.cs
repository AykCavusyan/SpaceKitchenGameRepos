using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;

public class testingscript : MonoBehaviour
{
    private GridSystem gridSystem;

    private void Start()
    {        
        gridSystem = new GridSystem(3, 2, 1f);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gridSystem.SetValue(Utils.Utils.GetMouseWorldPosition (), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log (gridSystem.GetValue(Utils.Utils.GetMouseWorldPosition()));
        }
    }
}
