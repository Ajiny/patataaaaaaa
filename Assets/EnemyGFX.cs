using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    public Vector2 movement;
    public float moveSpeed;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = aiPath.desiredVelocity.x;
        movement.y = aiPath.desiredVelocity.y;

        animator.SetFloat("Horizontal", movement.x); 
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (aiPath.desiredVelocity.x == 1 || aiPath.desiredVelocity.x == -1 || aiPath.desiredVelocity.y == 1 || aiPath.desiredVelocity.y == -1)
        {
            animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal")); 
            animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }



    }
}
