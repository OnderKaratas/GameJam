using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarekterMovement : MonoBehaviour
{
    public GameObject bullet;
    public Transform ateşnoktası;
    public float atışhızı;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    public void shoot()
    {
        GameObject mermi = Instantiate(bullet, ateşnoktası.position, Quaternion.identity);
        mermi.GetComponent<Rigidbody2D>().velocity=new Vector3(atışhızı*Time.deltaTime,0,0);
    }
}