using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadL1 : MonoBehaviour
{
    float timer;
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 2.3 && timer <= 2.6){
            SceneManager.LoadScene("LoadingOne");
        }
        
    }
}
