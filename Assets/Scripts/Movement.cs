using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Camera cam;
    public float thrust;
    public float torque;
    
    
    private Rigidbody2D rb;
    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void FixedUpdate()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(new Vector2(0, 1) * thrust);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(1 * torque);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-1 * torque);
        }
    }

}
