using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{


    private Rigidbody2D rb;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0f, -speed);  
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "bullet")
        {
            Destroy(gameObject);
        }
    }
}
