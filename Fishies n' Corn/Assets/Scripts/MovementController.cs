/*
A movement script, including an animation state machine, for a top-down RPG game
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    // instance variables
    public float movementSpeed = 3.0f;
    Vector2 movement = new Vector2();
    Animator animator;
    string animationState = "AnimationState";
    Rigidbody2D rb2D;
    public Inventory inventoryPrefab;
    Inventory inventory;

    public GameObject handIcon;
    public Sprite cornSprite;
    public Sprite tomatoSprite;

    public double wealth;

    public static int corns;
    public static int tomatos;
    public string selectedPlanter;

    // An enum is a set of enumerated constants.  Each constant is used to store an integer value to represent each animation state.
    enum CharStates
    {
        walkEast = 1,
        walkSouth = 2,
        walkWest = 3,
        walkNorth = 4,

        idleSouth = 5
    }

    private void Start()
    {
        // get components for animation and movement
        animator = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
        wealth = 2.0;

        selectedPlanter = "blank";
        handIcon.SetActive(false);

        inventory = Instantiate(inventoryPrefab);

    }

    private void Update()
    {
        // Call method to update animation state
        UpdateState();
        if(Input.GetKeyDown("1"))
        {
            selectedPlanter = "corn";
            handIcon.SetActive(true);
            handIcon.GetComponent<SpriteRenderer>().sprite = cornSprite;
        }
        else if (Input.GetKeyDown("2"))
        {
            selectedPlanter = "tomato";
            handIcon.SetActive(true);
            handIcon.GetComponent<SpriteRenderer>().sprite = tomatoSprite;
        }
    }

    int GetCornCount()
    {
        return corns;
    }

    void FixedUpdate()
    {
        // Call method to update movement
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        // the GetAxisRaw method takes a parameter specifying which 2D axis we are interested in, horizontal or vertical,
        //      and retrieves a -1, 0, or 1 from the Unity Input Manager and returns it.
        //      1 = "d" or "right arrow"; -1 = "a" of "left arrow"; 0 = no key pressed.  
        //      This is configurable in the Unity Input Manager settings.
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Normalize() will normalize our vector and keep the player moving at the same rate of speed, no matter the direction.
        movement.Normalize();

        // Set the velocity of the Rigidbody2D component to move the character
        rb2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        //Debug.Log(animator.GetInteger(animationState));
        // Setting character animation state based on movement direction.
        if (movement.x > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkEast);
        }
        else if (movement.x < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkWest);
        }
        else if (movement.y > 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkNorth);
        }
        else if (movement.y < 0)
        {
            animator.SetInteger(animationState, (int)CharStates.walkSouth);
        }
        else
        {
            animator.SetInteger(animationState, (int)CharStates.idleSouth);
        }
    }
}