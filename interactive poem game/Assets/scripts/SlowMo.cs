using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlowMo : MonoBehaviour
{
    public PlayerController playerScript;

    float timePressed;
    float maxTime = 5.3f;
    float coolDown = 2.5f;
    float timeSinceLast;

    bool coolingDown = false;
    bool isPressed;
    bool isValid;


    Image timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Image>();
        timePressed = 0;
        timeSinceLast = 6;

        isPressed = false;;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            timePressed += Time.unscaledDeltaTime;
            timeSinceLast = 0;
            Time.timeScale = 0.5f;
            timer.fillAmount -= timePressed / maxTime * Time.deltaTime;
        } else if (!isPressed)
        {
            timeSinceLast += Time.deltaTime;
            timePressed = 0;
            Time.timeScale = 1;
            coolingDown = true;
            if (coolingDown)
            {
                timer.fillAmount += maxTime * (Time.deltaTime / 12);
            }
        }
        //-------
        if(timePressed >= maxTime)
        {
            isPressed = false;
        }
        //--------
        if (Input.GetKey(KeyCode.LeftShift) && !isPressed && playerScript.playerStamina >= 4)
        {
            if (timeSinceLast >= coolDown)
            {
                isPressed = true;
                playerScript.playerStamina -= 3;
                coolingDown = false;
            }
        } else if (Input.GetKeyUp(KeyCode.LeftShift) && isPressed)
        {
            isPressed = false;
        }
    }
}
