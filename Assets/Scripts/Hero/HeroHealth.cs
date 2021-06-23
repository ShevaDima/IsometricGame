using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroHealth : MonoBehaviour
{
    public PlayerData PlayerData;
    
    public float Max;
    public float Current;

    public event Action Changed;


    private void Awake()
    {
        Current = Max = PlayerData.Health;
    }

    public void TakeDamage(float damage)
    {
        if(Current <= 0)
            return;

        Current -= damage;
        
        Changed?.Invoke();
    }
    
    public void AddHealth(float heal)
    {
        if(Current >= Max)
            return;

        Current += heal;
        
        Changed?.Invoke();
    }
}
