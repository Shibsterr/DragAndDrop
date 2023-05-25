﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjektuTransformacija : MonoBehaviour
{
    public Objekti objektuSkripts;


    // Update is called once per frame
    void Update()
    {
        if (objektuSkripts.pedejaisVilktais != null)
        {
            if (Input.GetKey(KeyCode.Z))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 13f);
            }

            if (Input.GetKey(KeyCode.X))
            {
                objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 13f);
            }

            //Up arrow
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y <= 0.8)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.001f);
                }

            }
            //Down arrow
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y >= 0.3)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x,
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.001f);
                }

            }

            //Right arrow
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x <= 0.8)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.001f,
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }

            }
            //Left Arrow
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x >= 0.3)
                {
                    objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().
                        transform.localScale = new Vector2(
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.001f,
                        objektuSkripts.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                }
            }
        }
    }
}