using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palanca : MonoBehaviour
{

    private Animator animator;
    public MovimientoP plataforma;
    // Start is called before the first frame update



    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            animator.SetTrigger("Entrada");
            plataforma.setMover(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other){
        if(other.CompareTag("Player")){
            animator.SetTrigger("Entrada");
        }
    }
}
