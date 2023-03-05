using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    
    public GameObject geet;

    void awake()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            geet.SetActive(false);
        }
            
    }
}
