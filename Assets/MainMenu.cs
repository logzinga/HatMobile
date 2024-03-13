using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LoadLevel;

    public void PlayGame() {
        print("Loading " + LoadLevel);
        SceneManager.LoadScene(LoadLevel);
    }

    public void QuitGame() {
        print ("Exiting Game");
        Application.Quit();
    }
}
