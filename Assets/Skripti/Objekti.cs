using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabas visus velkmaos objektus
	public GameObject AtkritumuMasina;
	public GameObject AtraPalidziba;
	public GameObject Autobuss;

	//Uzglabas katra transportlidzekla sakotnejo atrasanas vietu
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 AtraPalKoord;
	[HideInInspector]
	public Vector2 BussKoord;

	public Canvas kanva;

	//Uzglabas audio avoti
	public AudioSource SkanasAvots;
	//Uzglabas audio failus
	public AudioClip[] skanaKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;

	// Use this for initialization
	void Start () {
		//Uzsakot speli piefikse kur sakotneji atrodas katra masina
		atkrKoord = AtkritumuMasina.GetComponent<RectTransform>().localPosition;
		AtraPalKoord = AtraPalidziba.GetComponent<RectTransform>().localPosition;
		BussKoord = Autobuss.GetComponent<RectTransform>().localPosition;

	}
	
}
