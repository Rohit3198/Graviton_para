using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float moveSpeed;

    public float slowMoveSpeed;

    public float knockback;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

    public bool isbubbled;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (knockbackCount <= 0)
        {
            if (!isbubbled)
                Movement();
            else if (isbubbled)
                SlowMovement();
        }
        else if(knockbackCount>0)
        {
            if (knockFromRight)
            {
                rb.velocity =new Vector3(-knockback, knockback, 0);
            }
            if (!knockFromRight)
            {
                rb.velocity = new Vector3(knockback, knockback, 0);
            }
            knockbackCount -= Time.deltaTime;
        }
    }

    void Movement()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }
    void SlowMovement()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * slowMoveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * slowMoveSpeed * Time.deltaTime);
        }
    }
}
