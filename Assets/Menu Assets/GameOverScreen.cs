using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void Restart(){
        SceneManager.LoadScene(1);
    }

    public void MainMenu(){
        SceneManager.LoadScene(0);
    }
}
