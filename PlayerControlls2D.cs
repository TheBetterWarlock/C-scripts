using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls2D : MonoBehaviour
{
    [SerializeField] private float playerMovementSpeed = 1f;
    private int facingInt;

    private void Update()
    {
        // Horizontal Movement

        GetAxis() {
            transform.position.x = transform.position.x * playerMovementSpeed * //axis
            if (/*axis*/ < -0.1f)
            {
                facingInt = -1;
            } else if (/*axis*/ > 0.1f)
            {
                facingInt = 1;
            }
        }

        // Vertical Movement

        GetKeyDown() {
            if (OnGroundChecker())
            {
                // Add vertical force
            }
        }

        // Attacking

        GetMouseDown () {
            // 
        }
    }

    public bool OnGroundChecker()
    {
        // Checks for Contact with Ground


    }
}