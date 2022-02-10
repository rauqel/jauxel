using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L2death : MonoBehaviour
{
    public void Retry(){
        SceneManager.LoadScene("Level 2");
    }

    public void Exit(){
        Application.Quit();
    }
}
