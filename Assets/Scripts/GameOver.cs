using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private float timer = 0;
    
    // Update is called once per frame
    private void Update()
    {
        //Increase timer with delta time
        timer += Time.deltaTime;

        //If timer is greater than 2
        if (timer > 2)
        {
            //Reset data score
            Data.score = 0;

            //Load gameplay scene
            SceneManager.LoadScene("Gameplay");
        }
    }
}
