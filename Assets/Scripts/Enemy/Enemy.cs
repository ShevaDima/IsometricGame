﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    Patrol patrol;
    [SerializeField]
    AIDestinationSetter destination;
    [SerializeField]
    GameObject target;

    void Start()
    {
        
    }


    void FixedUpdate()
    {
        float distance = Vector2.Distance(transform.position, target.transform.position);

        if (distance < 3f)
        {
            patrol.enabled = false;
            destination.enabled = true;
        }
        else
        {
            destination.enabled = false;
            patrol.enabled = true;
        }
    }
}
