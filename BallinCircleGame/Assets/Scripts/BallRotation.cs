using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{

    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        speed = -speed;
    }

}
