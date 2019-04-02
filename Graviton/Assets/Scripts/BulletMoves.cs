using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoves : MonoBehaviour
{
    [SerializeField]
    private Vector3 lvlSpawn;

    public bool isrightBullet;
    
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(isrightBullet)
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        else if(!isrightBullet)
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        Destroy(this.gameObject, 3);
    }

    void OnCollisionEnter(Collision col)
    {
        col.gameObject.transform.position = lvlSpawn;
        Destroy(this.gameObject);
    }
}
