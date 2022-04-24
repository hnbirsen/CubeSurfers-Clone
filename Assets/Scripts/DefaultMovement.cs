using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultMovement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float sidewaysSpeed;

    void Start()
    {
        
    }

    void Update()
    {

        transform.Translate(0, 0, forwardSpeed * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            var touch = Input.touches[0];

            float horizontalAxis;

            if (touch.position.x <= Screen.width / 2)    // left
            {
                horizontalAxis = -0.5f * sidewaysSpeed * Time.deltaTime;

                transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
            }
            else    // right
            {
                horizontalAxis = 0.5f * sidewaysSpeed * Time.deltaTime;

                transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
            }
        }
    }
}
