using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterMovement : MonoBehaviour
{
    public GameObject bullet;
    public Transform ateşnoktası;
    public float atışhızı;
    public float Sayaç;
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
    }
    public void shoot()
    {
        GameObject mermi = Instantiate(bullet, ateşnoktası.position, Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity=new Vector2(atışhızı*Time.deltaTime,0);
    }
}