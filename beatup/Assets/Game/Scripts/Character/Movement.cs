using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private bool userControlled = false;

    private Animator moveAnim;
    private Rigidbody2D rigidBdy;

    private void UserMovementUpdate()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        moveAnim.SetFloat("horizontal", horizontal);
        moveAnim.SetFloat("vertical", vertical);

        this.rigidBdy.AddForce(new Vector2(horizontal, vertical));

    }

    // Use this for initialization
    void Start()
    {
        this.moveAnim = this.GetComponent<Animator>();
        this.rigidBdy = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (this.userControlled)
        {
            this.UserMovementUpdate();
        }
    }
}
