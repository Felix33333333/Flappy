using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KycklingRörelse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1 * Time.deltaTime, 0, 0);
        if (transform.position.x < -12)
        {
            transform.position = new Vector3(12, Random.Range(-3,3), 0);
        }
    }
}
