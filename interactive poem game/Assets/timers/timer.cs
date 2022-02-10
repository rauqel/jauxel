using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMain : MonoBehaviour
{
    float timeCount;

    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount >= 2.3 && timeCount <= 2.6){
            SceneManager.LoadScene("TitleLoading");
        }
        
    }
}
