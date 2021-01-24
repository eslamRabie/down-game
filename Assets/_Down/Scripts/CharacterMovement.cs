using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace _DownGame
{
    public class CharacterMovement : MonoBehaviour
    {
        [SerializeField]
        float MovementSpeed = 10;
        [SerializeField]
        Rigidbody2D rigidBody;
        float horizontalAxis;
        Vector2 velocity;

        void Start()
        {

        }

        void Update()
        {
            horizontalAxis = Input.GetAxis("Horizontal");
            if (horizontalAxis != 0)
                velocity.x = horizontalAxis * MovementSpeed;

            // changing right vector
            if (velocity.x > 0.05)
            {
                transform.right = Vector2.right;
            }
            else if (velocity.x < -0.05)
            {
                transform.right = Vector2.left;
            }
            rigidBody.velocity = velocity;
        }
    }
}