using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float verticalBound = 15;
    private float horizontalBound = 35;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -verticalBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z > verticalBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x <-horizontalBound)
        {
            Destroy(gameObject);
        } else if (transform.position.x > horizontalBound)
        {
            Destroy(gameObject);
        }
    }
}
