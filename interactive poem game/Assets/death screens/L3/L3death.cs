using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L3death : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("Level 3");
    }

    public void Exit(){
        Application.Quit();
    }
}
