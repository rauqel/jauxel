using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerObject;

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    public bool isOnGround;
    float movementValueX;
    public float playerSpeed = 3.0f;

    public float jumpForce = 0.5f;

    int maxStamina = 10;
    public int playerStamina;
    float staminaTimer;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GetComponent<Rigidbody2D>();

        playerStamina = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        // walking mechanic
        movementValueX = Input.GetAxis("Horizontal");
        playerObject.velocity = new Vector2(movementValueX * playerSpeed, playerObject.velocity.y);

        //
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 0.1f, whatIsGround);

        // jumping + stamina mechanic
        // these first two if statement limits the players stamina to the intended amount
        if(playerStamina > 0){
            if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
                playerObject.AddForce(new Vector2(0.0f, jumpForce));
                playerStamina = playerStamina - 1;
            }
        }
        if(playerStamina <= 0){
            playerStamina = 0;
        }

        staminaTimer = staminaTimer + Time.unscaledDeltaTime;
        if(staminaTimer >= 14.5 && staminaTimer <= 15.5){
            staminaTimer = 0f;
            if(playerStamina >= maxStamina){
                playerStamina = maxStamina;
            }
            else if(playerStamina >= 0 && playerStamina < maxStamina){
                playerStamina += 1;
            }
        }
        else{
            staminaTimer = staminaTimer + Time.deltaTime;
        }
    }
}
