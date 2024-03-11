using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public string NextLevel;

    public void EndGame() {
        SceneManager.LoadScene(NextLevel);
        print("Loading " + NextLevel);
    }
}
