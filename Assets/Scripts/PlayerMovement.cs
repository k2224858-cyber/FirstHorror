using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    Vector2 direction;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Debug.Log(x);
        Debug.Log(z);

    }
    private void FixedUpdate()
    {

        //rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);

    }
    

    
}
