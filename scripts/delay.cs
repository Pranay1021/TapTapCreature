using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delay : MonoBehaviour
{
    public AudioSource geet;



    // Update is called once per frame
    void Update()
    {
      AudioSource geet = GetComponent<AudioSource>();
        geet.PlayDelayed(3);
    }
}
