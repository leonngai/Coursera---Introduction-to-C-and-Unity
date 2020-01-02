using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidBody;
    Vector2 thrustDirection;
    float radius;

    const int ThrustForce = 2;
    const int RotateDegreesPerSecond = 20;
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        radius = gameObject.GetComponent<CircleCollider2D>().radius;

    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = RotateDegreesPerSecond * Time.deltaTime;
        float rotationInput = Input.GetAxis("Rotate");

        if (rotationInput != 0)
        {
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
            }

            transform.Rotate(Vector3.forward, rotationAmount);
            float rotationAroundZAxis = Mathf.Deg2Rad * transform.eulerAngles.z;
            thrustDirection = new Vector2(Mathf.Cos(rotationAroundZAxis), Mathf.Sin(rotationAroundZAxis));
        }
    }

    void OnBecameInvisible()
    {
        Vector2 initialPosition = transform.position;
        if (transform.position.x > ScreenUtils.ScreenRight)
        {
            initialPosition.x = ScreenUtils.ScreenLeft - radius;
        }
        if (transform.position.x < ScreenUtils.ScreenLeft)
        {
            initialPosition.x = ScreenUtils.ScreenRight - radius;
        }
        if (transform.position.y > ScreenUtils.ScreenTop)
        {
            initialPosition.y = ScreenUtils.ScreenBottom - radius;
        }
        if (transform.position.y < ScreenUtils.ScreenBottom)
        {
            initialPosition.y = ScreenUtils.ScreenTop - radius;
        }

        transform.position = initialPosition;
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Thrust") > 0)
        {
            rigidBody.AddForce(thrustDirection * ThrustForce, ForceMode2D.Force);
        }
        
    }
}
