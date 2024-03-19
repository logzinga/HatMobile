using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    public string ResetLevel;
    public string NextLevel = "MainMenu";

    public void EndGame() {
        SceneManager.LoadScene(ResetLevel);
        print("Loading " + ResetLevel);
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(NextLevel);
        print("Loading " + NextLevel);
    }

}
