using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAreaLimiter : MonoBehaviour
{
     public  GameObject brickSpawnPoint;
     public  GameObject spawnArea1;
     public  GameObject spawnArea2;
    // Start is called before the first frame update
    void Start()
    {
    brickSpawnPoint = GameObject.Find("BrickSpawnPoint");
    spawnArea1 = GameObject.Find("SpawnArea1");
    spawnArea2 = GameObject.Find("SpawnArea2");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter (Collider other)
    {
        other.GetComponent(tag);
        if (other.tag == "SpawnArea1")
        {
            brickSpawnPoint.transform.position = new Vector3(2.3127f, brickSpawnPoint.transform.position.y, 0.598f);
        }
        if (other.tag == "SpawnArea2")
        {
            brickSpawnPoint.transform.position = new Vector3(2.3127f, brickSpawnPoint.transform.position.y+0.0580728f, 0.3821f);
        }
    }

}
