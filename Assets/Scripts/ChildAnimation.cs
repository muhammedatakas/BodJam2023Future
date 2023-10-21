using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildAnimation : MonoBehaviour
{ [SerializeField] Animator animator;
    Rigidbody2D rb;
    [SerializeField] PlayerControlSimdi playerControlSimdi;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isGrounded", true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (rb.velocity.x > 0.2 || rb.velocity.x < -0.2) { animator.SetBool("isWalking", true); }
        else animator.SetBool("isWalking", false);
        if (playerControlSimdi.isGrounded())
        {
            animator.SetBool("isGrounded", true);
        }
        else animator.SetBool("isGrounded", false);
    }
}
