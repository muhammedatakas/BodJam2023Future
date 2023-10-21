using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdultAnimation : MonoBehaviour
{
    [SerializeField] Animator animator;
    Rigidbody2D rb;
    [SerializeField] PlayerControlGelecek playerControlGelecek;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isGrounded", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.x == 0)
        {
            animator.SetBool("isWalking", false);
        }
        if (rb.velocity.x > 0.04 || rb.velocity.x < -0.04) { animator.SetBool("isWalking", true); }
        if (playerControlGelecek.isGrounded())
        {
            animator.SetBool("isGrounded", true);
        }
        else animator.SetBool("isGrounded", false);
    }
}
