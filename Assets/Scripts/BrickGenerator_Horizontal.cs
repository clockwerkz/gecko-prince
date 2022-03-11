using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BrickGenerator_Horizontal : MonoBehaviour
{
    public  GameObject brickPrefab;
    public  GameObject brickSpawnPoint;
    public static GameObject newBrick;
    // Start is called before the first frame update
    void Start()
    {
     brickSpawnPoint.transform.position.Set(2.3127f, 0.7831272f, 0.3821f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        //GetComponent(tag);
       // if (gameObject.tag == "Sphere")
       // {
            newBrick = Instantiate(brickPrefab, brickSpawnPoint.transform.position, brickPrefab.transform.rotation);
            brickSpawnPoint.transform.position = new Vector3(brickSpawnPoint.transform.position.x+0.0942f, brickSpawnPoint.transform.position.y, brickSpawnPoint.transform.position.z);
            
        //}
    }
    
   /* public void OnTriggerEnter ()
    {
        spawnArea.GetComponent(tag);
        if (spawnArea.tag == "SpawnArea")
        {
            brickSpawnPoint.transform.position = new Vector3(brickSpawnPoint.transform.position.x, brickSpawnPoint.transform.position.z+0.2108f);
        }
    }
*/
}
