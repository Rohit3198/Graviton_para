using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slows : MonoBehaviour
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
        var players = other.GetComponent<PlayerController>();
        
        players.isbubbled = true;
    }

    void OnTriggerExit(Collider other)
    {
        var players = other.GetComponent<PlayerController>();
        players.isbubbled = false;
    }
}
