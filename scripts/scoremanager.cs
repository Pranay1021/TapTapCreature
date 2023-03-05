using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour
{
    public Text scoretext;
    private float score;
    public Text highscoretext;
    private float highscore;

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore");
    }
    
    
    
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null && GameObject.FindGameObjectWithTag("skk")==null)
        {
            score += 1 * Time.deltaTime;
            scoretext.text = ((int)score).ToString();
            highscoretext.text = ("Your best : ") + ((int)highscore).ToString();
            if (score > highscore)
            {
                PlayerPrefs.SetFloat("highscore", score);
            }



        }
        //else if (GameObject.FindGameObjectWithTag("Player") != null )
        {
            highscoretext.text = ("Your best : ") + ((int)highscore).ToString();
            if (score > highscore)
            {
                PlayerPrefs.SetFloat("highscore", score);
            }
        }



    }
}
