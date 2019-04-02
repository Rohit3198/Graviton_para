using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    [SerializeField]
    private Transform spawn;
    
    [SerializeField]
    private GameObject bullet;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Instantiate(bullet, spawn.position, Quaternion.identity);
    }
}
