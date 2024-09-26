using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private float height = 10f;
    private float horizontal;
    private Rigidbody2D rb;
    private bool isFacingRight = false;
    private Animator animator;


    private void Awake()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
        this.animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        this.rb.velocity = new Vector2(horizontal * speed, this.rb.velocity.y);
        animator.SetFloat("speed", Mathf.Abs(horizontal));

        if (Input.GetKeyDown(KeyCode.Space))
            {
            this.rb.AddForce(Vector2.up * height, ForceMode2D.Impulse);
            animator.SetTrigger("Pular");
        }

        Flip();

        /*if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Apertou espaço");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Clicou com o botão direito");
        }*/
    }

    
    private void Flip()
    {
        if (isFacingRight && horizontal < 0 || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
     

}
