using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       rb.AddForce(transform.right * 10f, ForceMode2D.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
