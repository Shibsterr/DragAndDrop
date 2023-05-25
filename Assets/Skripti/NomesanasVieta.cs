using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	public Objekti objektuSkripts;
	
	
	
	public void OnDrop(PointerEventData eventData)
    {
        if(eventData.pointerDrag != null)
		{
			if(eventData.pointerDrag.tag.Equals(tag))
			{
				//Rotacija
				vietasZRot = GetComponent<RectTransform>().transform.eulerAngles.z;
                velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform>().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs(velkObjZRot-vietasZRot);

				//Lielums
				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform>().localScale;
                vietasIzm = GetComponent<RectTransform>().localScale;

				xIzmeruStarp = Mathf.Abs(velkObjIzm.x - vietasIzm.x);
                yIzmeruStarp = Mathf.Abs(velkObjIzm.y - vietasIzm.y);

                Debug.Log("Rotacijas starpiba: "+rotacijasStarpiba+ 
					"\nx starpiba: "+xIzmeruStarp+ 
					"\ny starpiba: "+yIzmeruStarp);

				if((rotacijasStarpiba <= 8 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1))
				{
					Debug.Log("Nolikts pareizaja vieta");
					objektuSkripts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
					eventData.pointerDrag.GetComponent<RectTransform>().localRotation = GetComponent<RectTransform>().localRotation;
					eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

					switch(eventData.pointerDrag.tag){
						case "atkritumi":
							objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[1]);
							break;

						case "buss":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
                            break;

						case "medicina":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
                            break;

						default:
							Debug.Log("Tags netika atpazits");
							break;
					}

				}
			}else{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[0]);
                switch (eventData.pointerDrag.tag)
                {
                    case "atkritumi":
						objektuSkripts.AtkritumuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.atkrKoord;
                        break;

                    case "buss":
                        objektuSkripts.Autobuss.GetComponent<RectTransform>().localPosition = objektuSkripts.BussKoord;
                        break;

                    case "medicina":
                        objektuSkripts.AtraPalidziba.GetComponent<RectTransform>().localPosition = objektuSkripts.AtraPalKoord;
                        break;

                    default:
                        Debug.Log("Tags netika atpazits");
                        break;
                }
            }
		}
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
