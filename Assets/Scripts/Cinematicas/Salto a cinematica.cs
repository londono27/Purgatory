using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Saltoacinematica : MonoBehaviour
{
    public float tiempoCinemática;
    public int escenaSalto;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Esperar());
    }
    IEnumerator Esperar(){
        yield return new WaitForSeconds(tiempoCinemática); 
        SceneManager.LoadScene(escenaSalto);
    }

}
