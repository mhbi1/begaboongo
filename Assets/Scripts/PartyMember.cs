using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMember : MonoBehaviour {
    public Health HP = new Health ();
    public List<Enchantment> Enchantments = new List<Enchantment> ();
    public CharacterInfo CharacterInfo = new CharacterInfo ();

    public Sprite HPBar { get; set; }

    void Start () { }
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown (0)) {
            HP.TakeDamage (.1f);
        }
    }
}