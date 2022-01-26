using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaScript : MonoBehaviour
{

    public PlayerController script;

    Image staminaBar;
    float maxStamina = 10;

    // Start is called before the first frame update
    void Start()
    {
        staminaBar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        staminaBar.fillAmount = script.playerStamina / maxStamina;
    }
}
