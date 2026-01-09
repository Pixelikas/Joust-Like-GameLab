using UnityEngine;

public class PlayerOneMove : MonoBehaviour
{

    // Variables to horizontal and vertical input
    private float horizontalInputOne;
    private float verticalInputOne;

    // Variable to player speed
    private float moveSpeedOne = 5f;

    // Variable to player impulse
    private float impulseForceOne = 10f;

    // Variable to player physics component (Rigidbody2D)
    private Rigidbody2D playerPhysicsOne;

    void Awake(){

        // Component reference rigidbody
        playerPhysicsOne = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // Axis inputs to variables
        horizontalInputOne = Input.GetAxis("HorizontalP1");

        // Calculate inputs x speed in new vector2 and use it to set linear velocity of player physics 
        playerPhysicsOne.linearVelocity = new Vector2(horizontalInputOne * moveSpeedOne, playerPhysicsOne.linearVelocity.y);

        // Check impulse button
        if (Input.GetButtonDown("Jump"))
        {

            // Apply impulse to player physics
            playerPhysicsOne.AddForce(Vector2.up * impulseForceOne, ForceMode2D.Impulse);

        }

    }
}
