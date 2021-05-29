using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : MonoBehaviour
{
    public float Max;
    public float Current;

    public event Action Changed;

    private void Awake()
    {
        Current = Max;
    }

    public void TakeDamage(float damage)
    {
        if(Current <= 0)
            return;

        Current -= damage;
        
        Changed?.Invoke();
    }
}
