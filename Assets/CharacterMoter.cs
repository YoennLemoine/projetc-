using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;


public class CharacterMoter : MonoBehaviour
{
    // Animation du perso 

    Animator PlayerAnimator;
    

    public float walkSpeed;
    public float runSpeed;
    public float gravity;
    public float jumpSpeed;


    public string inputFront;
    public string inputBack;
    public string inputLeft;
    public string inputRight;



    public Vector3 moveD = Vector3.zero;
    CharacterController Cac;

    CapsuleCollider playerCollider;


   
    // Start is called before the first frame update
    void Start()
    {
        Cac = GetComponent<CharacterController>();
        PlayerAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Cac.isGrounded)
        {
            moveD = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            PlayerAnimator.SetFloat("walk", Input.GetAxis("Vertical"));
            PlayerAnimator.SetFloat("StrafeLeft", Mathf.Abs(Input.GetAxis("Horizontal"))) ;
            PlayerAnimator.SetFloat("Jump", Input.GetAxis("Jump"));

            moveD = transform.TransformDirection(moveD);
            moveD *= jumpSpeed;

            if(Input.GetButton("Jump"))
            {
                moveD.y = jumpSpeed;
            }
        }
        moveD.y -= gravity * Time.deltaTime;

        Cac.Move(moveD * Time.deltaTime);
    }
}
