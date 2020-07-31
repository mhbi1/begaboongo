using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Unit {
    public string Intent { get; set; }
    public AttackRoster AttackList { get; set; }
}