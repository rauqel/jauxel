using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerObject;

    public GameObject groundChecker;
    public LayerMask whatIsGround;

    bool isOnGround;
    float movementValueX;
    public float playerSpeed = 3.0f;

    public float jumpForce = 0.5f;

    int maxStamina = 10;
    int playerStamina;
    int staminaTimer;

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
        isOnGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        // jumping + stamina mechanic
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
            if(playerStamina > 0 && playerStamina <= maxStamina){
            playerObject.AddForce(new Vector2(0.0f, jumpForce));
            playerStamina -= 1;
            }
            if(playerStamina == 0){
                playerObject.AddForce(new Vector2(0.0f, 0.0f));
            }
        }
        if

    }
}
