using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plaaay : MonoBehaviour
{
    public GameObject started;
    public GameObject suru;
    public GameObject numb;
    public void start()
    {
        
        started.SetActive(false);
        suru.SetActive(true);
        numb.SetActive(true);
        }
    public void quit()
    {
        Application.Quit();
        Debug.Log("byeeeee");
    }
    
}
