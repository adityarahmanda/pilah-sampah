using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audioBenar;
    public AudioClip audioSalah;
    private AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textScore;

    // Start is called before the first frame update
    private void Start()
    {
        //Add new audio source component and assign it to MediaPlayerBenar
        MediaPlayerBenar = gameObject.AddComponent<AudioSource>();

        //Assign MediaPlayerBenar's clip
        MediaPlayerBenar.clip = audioBenar;

        //Add new audio source component and assign it to MediaPlayerSalah
        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();

        //Assign MediaPlayerSalah's clip
        MediaPlayerSalah.clip = audioSalah;
    }

    //Check if any game object enter the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if it's desirable gameobject
        if (collision.tag.Equals(nameTag))
        {
            //Increase data score by 10
            Data.score += 10;

            //Display the new score in Text Score UI
            textScore.text = Data.score.ToString();

            //Destroy the gameobject
            Destroy(collision.gameObject);

            //Play the MediaPlayerBenar audio clip
            MediaPlayerBenar.Play();
        }

        //if it's not desirable gameobject
        else
        {
            //Substract data score by 15
            Data.score -= 15;

            //Display the new score in Text Score UI
            textScore.text = Data.score.ToString();

            //Destroy the gameobject
            Destroy(collision.gameObject);

            //Play the MediaPlayerSalah audio clip
            MediaPlayerSalah.Play();

            //If data score is less or equals to 0
            if(Data.score <= 0)
            {
                //Load game over scene
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
