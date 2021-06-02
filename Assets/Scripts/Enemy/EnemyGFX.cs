using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath path;
    public SpriteRenderer sr;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (path.desiredVelocity.x >= 0.01f)
        {
            sr.flipX = true;
        }
        else if (path.desiredVelocity.x <= -0.01f)
        {
            sr.flipX = false;
        }
    }
}
