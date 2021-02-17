using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterMovement : MonoBehaviour
{
    public GameObject bullet;
    public float moveSpeed;
    public Transform ateşnoktası;
    public float atışhızı;
    public float Sayaç;
    Vector2 movement;
    public Rigidbody2D rb;
    public Vector2 JumpForce;
    bool jump;

    private void Update()
    {
        Sayaç -= Time.deltaTime;
        if (Input.GetMouseButtonDown(0))
        {
            if (Sayaç <= 0)
            {
                shoot();
                Sayaç = 0.5f;
            }
        }
        movement.x=Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump=true;
        }
        
    }
    public void shoot()
    {
        GameObject mermi = Instantiate(bullet, ateşnoktası.position, Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity=new Vector2(atışhızı*Time.deltaTime,0);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+movement*moveSpeed*Time.fixedDeltaTime);
        ProcessJump();
    }
    private void ProcessJump()
    {
        if(jump)
        {
            rb.AddForce(JumpForce*Time.deltaTime, ForceMode2D.Force);
            jump = false;
        }

    }
    
}