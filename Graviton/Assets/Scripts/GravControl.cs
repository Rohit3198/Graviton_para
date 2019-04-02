using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravControl : MonoBehaviour
{
    private Rigidbody rb;
    public float gravity;
    private bool gravswitch = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gravswitch == true)
        {
            rb.velocity = new Vector3(0, gravity, 0);
        }
        else if(gravswitch == false)
        {
            rb.velocity = new Vector3(0, -gravity, 0);
        }

        if(Input.GetKeyDown(KeyCode.Space) && gravswitch == true)
        {
            gravswitch = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && gravswitch==false)
        {
            gravswitch = true;

        }
        
    }
}
