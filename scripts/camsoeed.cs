using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camsoeed : MonoBehaviour
{
    // Start is called before the first frame update
    public float cam;
   private float time;
    private float samay;
    

   

    // Update is called once per frame
    void Update()
    {
        cam = 11.0f;
        
        time = 0;
        samay += 1 * Time.deltaTime;
    
        while(time < samay)
        {
            
            time += time + 80;
            
            transform.position += new Vector3(cam * Time.deltaTime, 0, 0);
            cam=cam+0.1f;
            
        }
        
    }
}
