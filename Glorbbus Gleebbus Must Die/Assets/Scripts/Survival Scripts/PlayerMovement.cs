using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // give the player sprite the Character Controller 2D Script firat
    // give Player Movement after and make the game object (body) the Controller

    // each character needs a top collider and a bottom collider for crouch
    // character needs box collider 2D on top, circle collider 2D on bottom
    // each player object needs a blank player object to check ceiling and check ground

    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch")) {
            crouch = true;
        } else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
