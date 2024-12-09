using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float power;
    public float time = 0;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.forward + Vector3.up * power;
        time += Time.deltaTime;
        if(time >= 3) { Destroy(gameObject); }
 
       
    }
}
