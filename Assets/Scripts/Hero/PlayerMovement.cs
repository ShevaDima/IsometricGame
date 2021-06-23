using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerData PlayerData;
    private Rigidbody2D rb;
    public float moveH, moveV;
    public float moveSpeed = 1.0f;
    

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        moveSpeed = PlayerData.Speed;
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal")*moveSpeed;
        moveV = Input.GetAxis("Vertical")*moveSpeed;
        rb.velocity = new Vector2(moveH, moveV);
        Vector2 direction = new Vector2(moveH, moveV);
        FindObjectOfType<PlayerAnimation>().SetDirection(direction);
    }

    void Update()
    {
        
    }
}
