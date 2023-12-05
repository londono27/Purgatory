using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;
    public GameObject transition;

    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;
    public GameObject ganador;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
        
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }
    public void AllFruitsCollected()
    {
        if(transform.childCount == 13)
        {
            Debug.Log("No quedan frutas");
            //levelCleared.gameObject.SetActive(true);
            transition.gameObject.SetActive(true);
            ContadorNiveles.Instance.SetNivelesC(2);
            Debug.Log(ContadorNiveles.Instance.GetNivelesC());
            Invoke("ChangeScene", 1);

        }
    }

    void ChangeScene()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            Time.timeScale = 0;
            ganador.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            
        }
    }
}
