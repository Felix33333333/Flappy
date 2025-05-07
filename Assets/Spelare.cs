using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spelare : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Hopp");
            rigidbody2D.AddForce(new Vector2(0, 6), ForceMode2D.Impulse);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -5, 5), transform.position.z);
        //hoppa
            //åker upp
        //gravitation
    }
}
