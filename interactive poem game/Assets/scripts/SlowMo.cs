using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMo : MonoBehaviour
{
    public PlayerController playerScript;

    float timePressed;
    float maxTime;
    float coolDown = 1;
    float timeSinceLast;
    bool isPressed;
    bool allowSlowMo;


    Image timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Image>();
        timePressed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            timePressed += Time.unscaledDeltaTime;
        } else if (!isPressed)
        {
            timeSinceLast += Time.deltaTime;
        }
        //-------
        if((timePressed >= 0.0 && timePressed <= 0.1) && timeSinceLast >= coolDown)
        {
            allowSlowMo = true;
            isPressed = false;
        }
        //--------
        if(timePressed == maxTime)
        {
            allowSlowMo = false;
            isPressed = false;
        } else if(timePressed < maxTime && timePressed >= 0)
        {
            allowSlowMo = true;
        }
        //--------
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isPressed = true;
        } else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isPressed = false;
            Time.timeScale = 1.0f;
        }
        //--------
        if(allowSlowMo && isPressed && playerScript.playerStamina >= 5)
        {
            Time.timeScale = 0.5f;
            timer.fillAmount = timePressed / maxTime;
            playerScript.playerStamina -= 3;
        }
    }
}
