using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingscript : MonoBehaviour
{
    private void Start()
    {
        GridSystem testGrid = new GridSystem(10, 5, 10f);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {

        }
    }
}
