using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject bullet;
    public Transform ateşnoktası;
    public float atışhızı;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            GameObject mermi = Instantiate(bullet, ateşnoktası.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
