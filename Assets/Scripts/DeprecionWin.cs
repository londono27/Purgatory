using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeprecionWin : MonoBehaviour
{
    // Start is called before the first frame update

     public GameObject ganador;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            ganador.SetActive(true);
            ContadorNiveles.Instance.SetNivelesC(6);
            
        }
    }
}
