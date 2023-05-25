using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglabas visus velkmaos objektus
	public GameObject AtkritumuMasina;
	public GameObject AtraPalidziba;
	public GameObject Autobuss;
	public GameObject b2Masina;
	public GameObject CementuMasina;
	public GameObject e46Transports;
	public GameObject e61Trans;
	public GameObject EskavatorsMas;
	public GameObject Policija;
	public GameObject Traktors1;
	public GameObject TraktorsZ5;
	public GameObject UgunsdzesejsMas;
	public GameObject UzvarasPanele;

    //Uzglabas katra transportlidzekla sakotnejo atrasanas vietu
    [HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 AtraPalKoord;
	[HideInInspector]
	public Vector2 BussKoord;
    [HideInInspector]
    public Vector2 b2Koord;
    [HideInInspector]
    public Vector2 CemenKoord;
    [HideInInspector]
    public Vector2 e46Koord;
    [HideInInspector]
    public Vector2 e61Koord;
    [HideInInspector]
    public Vector2 EskavatorsKoord;
    [HideInInspector]
    public Vector2 PoliKoord;
    [HideInInspector]
    public Vector2 TraktKoord;
    [HideInInspector]
    public Vector2 TraktorsZalKoord;
    [HideInInspector]
    public Vector2 UgunsdzKoord;

    //Paslepj laiku un cik masinas ir atrastas
    [HideInInspector]
    public int cikIr;
    [HideInInspector]
    public float time;

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
		b2Koord = b2Masina.GetComponent<RectTransform>().localPosition;
		CemenKoord = CementuMasina.GetComponent<RectTransform>().localPosition;
		e46Koord = e46Transports.GetComponent<RectTransform>().localPosition;
		e61Koord = e61Trans.GetComponent<RectTransform>().localPosition;
		EskavatorsKoord = EskavatorsMas.GetComponent<RectTransform>().localPosition;
		PoliKoord = Policija.GetComponent<RectTransform>().localPosition;
		TraktKoord = Traktors1.GetComponent<RectTransform>().localPosition;
		TraktorsZalKoord = TraktorsZ5.GetComponent<RectTransform>().localPosition;
		UgunsdzKoord = UgunsdzesejsMas.GetComponent<RectTransform>().localPosition;
        cikIr = 0;
    }
	
}
