using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform[] puntosMoviendo;
    [SerializeField] private float velocidadMovimineto;
    private int siguientePlataforma = 1;
    private bool ordenPlataformas = true;


        public Movimiento_main jugador;

        private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
             jugador.Recolocar();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ordenPlataformas && siguientePlataforma + 1 >= puntosMoviendo.Length)
        {
            ordenPlataformas = false;
        }
        if(!ordenPlataformas && siguientePlataforma <= 0)
        {
            ordenPlataformas = true;
        }

        if(Vector2.Distance(transform.position, puntosMoviendo[siguientePlataforma].position) < 0.1f)
        {
            if(ordenPlataformas){
                siguientePlataforma += 1;
            }else{
                siguientePlataforma -= 1;
            }
        }

        transform.position = Vector2.MoveTowards( transform.position, puntosMoviendo[siguientePlataforma].position, velocidadMovimineto * Time.deltaTime);
    }
}
