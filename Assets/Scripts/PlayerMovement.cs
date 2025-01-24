using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 15f;  // Velocidad de movimiento
    public float rotationSpeed = 50f;  // Velocidad de rotación

    private Rigidbody rb;  // Referencia al Rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Obtenemos el Rigidbody del jugador
    }

    void Update()
    {
        Move();  // Llamamos a la función de movimiento en cada frame
    }

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");  
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized;

        if (movement.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationSpeed, 0.1f);
            transform.rotation = Quaternion.Euler(0, angle, 0);  // Rotar suavemente

            // Mover el jugador
            rb.MovePosition(transform.position + movement * moveSpeed * Time.deltaTime);
        }
    }
}
