using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    public int Gold { get; set; }
    public int DeckSize { get; set; }
    public int Energy { get; set; }

    public Card[] Deck { get; set; }
    public Card[] DiscardPile { get; set; }
    public Card[] Hand { get; set; }

    //public Relic[] Relics {get; set;}
    public PartyMember[] Party { get; set; }

    public Player () { }

    public void DrawCard () {

    }

    public Card PlayCard () {
        return new Card ();
    }

    public void ShuffleDeck () {

    }

    public void AddCardToDeck (Card card) { }

    public void AddPartyMember (PartyMember partyMember) {

    }

    public void RemovePartyMember (PartyMember partyMember) {

    }
}