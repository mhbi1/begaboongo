using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterInfo : MonoBehaviour {
    public string Name { get; set; }

    public Sprite Sprite { get; set; }

    public void SetName (string name) {
        Name = name;
    }

    public void SetSprite (Sprite sprite) {
        Sprite = sprite;
    }
}