using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class JumpBox : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public GameObject brokenParts;
    public float jumpForce = 5f;
    public int lifes = 1;
    public GameObject boxCollider;
    public Collider2D col2D;

    public GameObject skull;


    private void Start()
    {
        skull.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex != 4){
        skull.transform.SetParent(FindObjectOfType<FruitManager>().transform);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
            LosseLifeAndHit();
        }
    }

    public void LosseLifeAndHit()
    {
        lifes--;
        animator.Play("Hit");
        CheckLife();
    }

    public void CheckLife()
    {
        if (lifes <= 0)
        {

            
            boxCollider.SetActive(false);
            col2D.enabled = false;
            brokenParts.SetActive(true);
            spriteRenderer.enabled = false;
            Invoke("DestroyBox", 0.5f);
            skull.SetActive(true);
        }
    }

    public void DestroyBox()
    {
        Destroy(transform.parent.gameObject);
    }
}
