using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enchantment : MonoBehaviour {
    public enum EnchantmentType { Buff, Debuff }
    public string Name { get; set; }
    public string Effect { get; set; }
    public int Timing { get; set; }

    public void PerformAction () {

    }

}