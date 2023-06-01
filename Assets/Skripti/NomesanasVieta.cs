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
                            objektuSkripts.cikIr++;
							break;

						case "buss":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[3]);
                            objektuSkripts.cikIr++;
                            break;

						case "medicina":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[2]);
                            objektuSkripts.cikIr++;
                            break;

						case "b2Auto":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[4]);
                            objektuSkripts.cikIr++;
                            break;

						case "cements":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[5]);
                            objektuSkripts.cikIr++;
                            break;

                        case "e46auto":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[6]);
                            objektuSkripts.cikIr++;
                            break;

                        case "e61automas":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[7]);
                            objektuSkripts.cikIr++;
                            break;

                        case "eskavators":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[8]);
                            objektuSkripts.cikIr++;
                            break;

                        case "policija":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[9]);
                            objektuSkripts.cikIr++;
                            break;

                        case "traktors":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[10]);
                            objektuSkripts.cikIr++;
                            break;

                        case "traktorszalais":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[11]);
                            objektuSkripts.cikIr++;
                            break;

                        case "ugunsdz":
                            objektuSkripts.SkanasAvots.PlayOneShot(objektuSkripts.skanaKoAtskanot[12]);
                            objektuSkripts.cikIr++;
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

                    case "b2Auto":
                        objektuSkripts.b2Masina.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;

                    case "cements":
                        objektuSkripts.CementuMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.CemenKoord;
                        break;

                    case "e46auto":
                        objektuSkripts.e46Transports.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;

                    case "e61automas":
                        objektuSkripts.e61Trans.GetComponent<RectTransform>().localPosition = objektuSkripts.e61Koord;
                        break;

                    case "eskavators":
                        objektuSkripts.EskavatorsMas.GetComponent<RectTransform>().localPosition = objektuSkripts.EskavatorsKoord;
                        break;

                    case "policija":
                        objektuSkripts.Policija.GetComponent<RectTransform>().localPosition = objektuSkripts.PoliKoord;
                        break;

                    case "traktors":
                        objektuSkripts.Traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.TraktKoord;
                        break;

                    case "traktorszalais":
                        objektuSkripts.TraktorsZ5.GetComponent<RectTransform>().localPosition = objektuSkripts.TraktorsZalKoord;
                        break;

                    case "ugunsdz":
                        objektuSkripts.UgunsdzesejsMas.GetComponent<RectTransform>().localPosition = objektuSkripts.UgunsdzKoord;
                        break;
                    default:
                        Debug.Log("Tags netika atpazits");
                        break;
                }
            }
		}
    }
}
