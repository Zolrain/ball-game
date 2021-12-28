using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    private float movementX
    private float movementY

    void Start(InputValue movementValue)
    {
        rb = GetComponent<Rigidbody>;
         
            
        }
         void OnMove[]
         {
            Vector2 movementVector = movementValue.get <Vector2>;
            movementX = movementVector.X;    
            movementY = movementVector.Y;
         }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3[movementX 0.0f movementY];
        rb.AddForce;


    }

    // Update is called once per frame
   
}
