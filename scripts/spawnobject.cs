using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
    public GameObject obs;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenspawn;
    private float spawntime;
   
    // Start is called before the first frame update
    void Update()
    {

        if (Time.time > spawntime)
        {
          
            spawn();
            spawntime = Time.time + timebetweenspawn;
            
        }
    }

    // Update is called once per frame
    void spawn()
    {
        float randomx = Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);

        Instantiate(obs, transform.position + new Vector3(randomx, randomy, 0), transform.rotation);
    }
}
