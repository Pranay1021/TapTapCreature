using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundofplay : MonoBehaviour
{
    public AudioSource whip;
        
   

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            whip.Play();
        }
    }
}
