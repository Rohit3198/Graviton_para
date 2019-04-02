using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTex : MonoBehaviour
{
    public float scrollX;
    public float scrollY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offsetx = Time.time * scrollX;
        float offsety = Time.time * scrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetx, offsety);
    }
}
