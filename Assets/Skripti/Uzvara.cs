using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Uzvara : MonoBehaviour {
    public Objekti objektuSkripts;
    public Text timeText;
    public Text LaiksUzvarasLoga;
    private float timeToDisplay;
    private bool gamePaused = false;

    // Use this for initialization
    void Start() {
        objektuSkripts.time = 0;
        DisplayTime(objektuSkripts.time);
        objektuSkripts.UzvarasPanele3.SetActive(false);
        objektuSkripts.UzvarasPanele2.SetActive(false);
        objektuSkripts.UzvarasPanele1.SetActive(false);
    }
    // Update is called once per frame
    void Update() {
        if (!gamePaused)
        {
            objektuSkripts.time += Time.deltaTime;
            DisplayTime(objektuSkripts.time);
        }
        uzvarasLogs();
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void UzvarasLaiks(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        LaiksUzvarasLoga.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void uzvarasLogs(){
        if(objektuSkripts.cikIr == 12){
            if (objektuSkripts.time<=60) {
                gamePaused = true;
                objektuSkripts.UzvarasPanele3.SetActive(true);
                UzvarasLaiks(objektuSkripts.time);
            }else if(objektuSkripts.time > 60 && objektuSkripts.time <= 120){
                gamePaused = true;
                objektuSkripts.UzvarasPanele2.SetActive(true);
                UzvarasLaiks(objektuSkripts.time);
            }else if (objektuSkripts.time >= 180){
                gamePaused = true;
                objektuSkripts.UzvarasPanele1.SetActive(true);
                UzvarasLaiks(objektuSkripts.time);
            }
        }
    }
}
