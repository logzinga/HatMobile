using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public string ResetLevel;
    public string NextLevel;

    public void EndGame() {
        SceneManager.LoadScene(ResetLevel);
        print("Loading " + ResetLevel);
    }

    public void LoadNextLevel() {
        SceneManager.LoadScene(NextLevel);
        print("Loading " + NextLevel);
    }

}
