using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    public float speed;
    public int power;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        power = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(speed * Time.deltaTime * transform.forward);
            Debug.Log("mivng");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(speed * Time.deltaTime * -transform.forward);
        }

        if(power > 0)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(bullet, rb.position, Quaternion.identity);
                power = power - 1;
            }

        }

    }

}
