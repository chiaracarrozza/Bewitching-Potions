using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);//the menu won't appear at the beginning of the game
    }
    public void SetExit() //it will set the quit option on the quit button
    {
        Application.Quit();

    }
    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  //the player will be able to try again once they click the try agin button
    }

}
