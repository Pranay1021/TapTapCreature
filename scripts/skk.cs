using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skk : MonoBehaviour

{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("GameController")!=null)
        {
            Destroy(this.gameObject);
        }
    }
}
