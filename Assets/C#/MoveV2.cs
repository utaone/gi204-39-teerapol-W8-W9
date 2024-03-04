using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV2 : MonoBehaviour
{
    public Rigidbody rb3d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb3d.AddForce(0,0,2);
        }    
        
        if (Input.GetKey("a"))
        {
            rb3d.AddForce(-2,0,0);
        }    
        
        if (Input.GetKey("d"))
        {
            rb3d.AddForce(2,0,0);
        }    
        
        if (Input.GetKey("s"))
        {
            rb3d.AddForce(0,0,-2);
        }    
    }
}
