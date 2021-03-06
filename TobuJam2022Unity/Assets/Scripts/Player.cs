using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private PlayerInputActions playerActions;
    private Rigidbody2D rigidBody;
    private Vector2 moveInput;
    private Animator animator;

    private void OnEnable()
    {
        playerActions.Gameplay.Enable();
    }

    private void OnDisable()
    {
        playerActions.Gameplay.Disable();
    }

    private void Awake()
    {
        playerActions = new PlayerInputActions();

        rigidBody = GetComponent<Rigidbody2D>();
        if(rigidBody is null)
        {
            Debug.LogError("RigidBody2D is null!");
        }

        animator = GetComponent<Animator>();
        if (animator is null)
        {
            Debug.LogError("Animator is null!");
        }
    }
   
    private void FixedUpdate()
    {
        moveInput = playerActions.Gameplay.Movement.ReadValue<Vector2>();
        moveInput.y = 0f; // temporary fix in tutorial
        rigidBody.velocity = moveInput * speed;
        
        
        animator.SetBool("isIdle", moveInput.x == 0);
        if(moveInput.x != 0)
        {
            animator.SetBool("isFacingRight", moveInput.x > 0); //TODO: set name as constant!
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
