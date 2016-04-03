using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Extends card like CardProspector does
public class Bartok : MonoBehaviour {
	static public Bartok S;

	public TextAsset deckXML;
	public TextAsset layoutXML;
	public Vector3 layoutCenter = Vector3.zero;

	public bool __________;

	public Deck deck;
	public List<CardBartok> drawPile;
	public List<CardBartok> discardPile;

	void Awake(){
		S = this;
	}

	void Start(){
		deck = GetComponent<Deck> (); // Get the deck
		deck.InitDeck (deckXML.text); // Pass DeckXML to it
		Deck.Shuffle (ref deck.cards); // Tis shuffles the deck
		// The ref keyword passes a reference to deck.cards, which allows 
		// deck.cards to be moified by Deck.Shuffle()
	}
}
