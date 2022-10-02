using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour
{

    public Rigidbody2D rb;
    public int speed = 100;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = Vector2.up * speed;

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "enemy")
        {
            scoremanager.score += 10;
            Destroy(gameObject);
            playExplosion();
        }
    }
    private void playExplosion()
    {
        GameObject e = Instantiate(explosion) as GameObject;
        e.transform.position = transform.position;
        Destroy(e, 2.0f);


    }

}

  