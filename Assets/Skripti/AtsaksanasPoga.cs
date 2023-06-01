using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtsaksanasPoga : MonoBehaviour {

    public GameObject noteikumi;


    void Start(){
        noteikumi.SetActive(false);
    }
        public void AtsaktNoJauna(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void UzSakumu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void UzSpeli(){
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void Apturet()
    {
        Application.Quit();
    }

    public void Noteikumi(){
        noteikumi.SetActive(true);
    }

    public void AtpakalNoNoteikumiem()
    {
        noteikumi.SetActive(false);
    }

}
