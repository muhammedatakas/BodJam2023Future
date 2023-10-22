using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControlGelecek : MonoBehaviour
{
    Rigidbody2D rb;
    float input;
    float speed = 9f;
    Vector2 targetVelocity;
    public float jumpForce = 6f;
    bool isJumped;
    //bool isGrounded = true;
    bool isAlive;
    Vector3 scale;
    public Vector2 boxSize;
    public float castDistance;
    public LayerMask groundLayer;

    void Start()
    {
        scale = transform.localScale;
        rb = GetComponent<Rigidbody2D>();
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if (input > 0)
        {
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        else if (input < 0)
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            isJumped = true;
        }
    }

    private void FixedUpdate()
    {
        if (isAlive)
        {
            targetVelocity = new Vector2(input * speed, rb.velocity.y);

            rb.velocity = Vector2.Lerp(rb.velocity, targetVelocity, Time.fixedDeltaTime * 10f);
            if (isGrounded() && isJumped)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                isJumped = false;
                                AudioSource.PlayClipAtPoint(AudioManager.instance.jumpSound,transform.position);

            }
        }

    }
    public bool isGrounded()
    {
        if(Physics2D.BoxCast(transform.position, boxSize, 0,-transform.up, castDistance, groundLayer))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position-transform.up * castDistance,boxSize);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Level"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
              
        }
    }
}
