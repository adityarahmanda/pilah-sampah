using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keluar : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //If Escape is pressed from the keyboard
        if (Input.GetKeyUp(KeyCode.Escape))
        {

            //Quit the application
            Application.Quit();
        }
    }
}
