using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterMovement : MonoBehaviour
{
    public Vector2 sağ,sol,jump;
    bool sağcheck, solcheck, jumpcheck;
    public Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d.GetComponent<Rigidbody2D>();
        sağcheck = false;
        solcheck = false;
        jumpcheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            sağcheck = true;
    
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            sağcheck = false;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            solcheck = true;
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            sağcheck = false;

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpcheck = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            jumpcheck = false;
        }
    }
    private void ProcessSağ()
    {
        if (sağcheck)
        {
            rb2d.AddForce(sağ, ForceMode2D.Impulse);
            
        }
    }
    private void ProcessSol()
    {
        if (solcheck)
        {
            rb2d.AddForce(sol, ForceMode2D.Impulse);
            
        }
    }
    private void ProcessJump()
    {
        if (jumpcheck)
        {
            rb2d.AddForce(jump, ForceMode2D.Impulse);
            
        }
    }
    private void FixedUpdate()
    {
        ProcessSağ();
        ProcessSol();
        ProcessJump();
    }
}
