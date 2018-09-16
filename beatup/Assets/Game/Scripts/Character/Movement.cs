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
        #region basic float declaration
        float vertical = 0.0f;
        float horizontal = 0.0f;
        #endregion

        //SHOULD PROBABLY CHANGE THIS TO BE DONE VIA EXTERNAL CCONTROLLER SO WE CAN 
        //MAKE MOVEMENT CONTROLS MODULAR AND PORT TO ANY SORT OF CONTROLS
        if (this.userControlled)
        {
            vertical = Input.GetAxisRaw("Vertical");
            horizontal = Input.GetAxisRaw("Horizontal");
        }

        moveAnim.SetFloat("horizontal", horizontal);
        moveAnim.SetFloat("vertical", vertical);

        Vector2 force = new Vector2(horizontal, vertical);

        this.rigidBdy.AddForce(force);// * Time.fixedDeltaTime);

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
