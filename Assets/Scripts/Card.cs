using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {
    public virtual CardRarity CardRarity { get; set; }
    public virtual string Description { get; set; }
    public virtual int EnergyCost { get; set; }

    public PartyMember Possession { get; set; }

    public Action Action { get; set; }
}