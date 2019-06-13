using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = transform.right * 5f;
    }

 
    void Update()
    {
        
    }
}
