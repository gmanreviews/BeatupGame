using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Movement : MonoBehaviour
{
    [SerializeField]
    private bool userControlled = false;

    private Animator moveAnim;

    private void UserMovementUpdate()
    {
        moveAnim.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        moveAnim.SetFloat("vertical", Input.GetAxis("Vertical"));
    }

    // Use this for initialization
    void Start()
    {
        this.moveAnim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.userControlled)
        {
            this.UserMovementUpdate();
        }

    }
}
