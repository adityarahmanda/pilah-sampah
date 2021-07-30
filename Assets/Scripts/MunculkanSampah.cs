using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculkanSampah : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] obyekSampah;

    // Update is called once per frame
    private void Update()
    {
        //Increase timer with delta time
        timer += Time.deltaTime;

        //Spawn random objekSampah every time the timer is greater than jeda
        if (timer > jeda)
        {
            int random = Random.Range(0, obyekSampah.Length);
            Instantiate(obyekSampah[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
