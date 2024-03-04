using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
     Vector3 offset;
     Vector3 newpos;

     public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newpos = transform.position;
        newpos.x = player.transform.position.x - offset.x;
        newpos.z = player.transform.position.z - offset.z;
        newpos.y = player.transform.position.y - offset.y;
        transform.position = newpos;

    }
}
