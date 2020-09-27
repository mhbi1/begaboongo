using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health {

    public float CurrentHP { get; set; }

    public float MaxHP { get; set; }
    //Blocks
    public float TemporaryHP { get; set; } = 0.0f;

    public Health () {
        CurrentHP = MaxHP = 1.0f;
    }

    public void TakeDamage (float damageAmount) {
        CurrentHP -= damageAmount;
    }

    public void HealHP (float healAmount) {
        CurrentHP += healAmount;
        if (CurrentHP > MaxHP) {
            CurrentHP = MaxHP;
        }
    }

    public void GainTemporaryHealth (int shieldAmount) {
        TemporaryHP += shieldAmount;
    }

}