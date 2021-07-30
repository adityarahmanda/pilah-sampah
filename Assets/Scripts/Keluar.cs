using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            {
            Application.Quit();
            }
    }
}
