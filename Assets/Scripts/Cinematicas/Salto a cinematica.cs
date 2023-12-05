using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Saltoacinematica : MonoBehaviour
{
    public float tiempoCinemática;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Esperar());
    }
    IEnumerator Esperar(){
        yield return new WaitForSeconds(tiempoCinemática); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
