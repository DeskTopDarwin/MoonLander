using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainScript : MonoBehaviour
{
    public float MAX_VELOCITY = 0.5f;

    private  Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        //MAX_VELOCITY = new Vector2(0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayerDie()
    {
        Debug.Log("ahah u ded");
        gameObject.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //int foreGround = LayerMask.NameToLayer("ForeGround");
        int landingPad = LayerMask.NameToLayer("LandingPad");
       
        if (collision.gameObject.layer == landingPad && rb.velocity.x < MAX_VELOCITY)
        {
            Debug.Log("landed");
        }
        else
        {
            PlayerDie();
        }

    }
}
