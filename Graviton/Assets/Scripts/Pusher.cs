using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pusher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        var playerc = other.GetComponent<PlayerController>();

        if(other.name=="Player")
        {
            playerc.knockbackCount = playerc.knockbackLength;
            if(other.transform.position.x<transform.position.x)
            {
                playerc.knockFromRight = true;
            }
            else
            {
                playerc.knockFromRight = false;
            }
        }
    }
}
