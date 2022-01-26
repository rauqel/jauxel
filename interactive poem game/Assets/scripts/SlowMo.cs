using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMo : MonoBehaviour
{
    public PlayerController playerScript;

    float timePressed;
    float maxPressTime = 5.0f;

    Image timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Image>();
        Time.timeScale = 1.0f;
        timePressed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timePressed);

        if (Input.GetKey(KeyCode.LeftShift) && playerScript.playerStamina >= 5)
        {
            timePressed += Time.unscaledDeltaTime;
            
            if(Time.timeScale == 1.0f && timePressed > 0)
            {
                Debug.Log("working");
                Time.timeScale = 0.5f;
                timePressed += Time.unscaledDeltaTime;
                playerScript.playerStamina -= 5;
                timer.fillAmount = timePressed / maxPressTime;
            }
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || (timePressed >= 4.8 && timePressed <= 5.5))
        {
            Time.timeScale = 1.0f;
            timePressed = 0.0f;
        }
    }
}
