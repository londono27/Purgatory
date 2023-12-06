using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SkullManager2 : MonoBehaviour
{
    public Text levelCleared;
    public GameObject transition;

    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;
    public GameObject ganador;
    public GameObject CanvasTime;
    public GameObject CanvasPuntos;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;

    }

    private void Update()
    {
        totalFruits.text = totalFruitsInLevel.ToString();
        int temp = totalFruitsInLevel - transform.childCount;
        fruitsCollected.text = temp.ToString();
        AllFruitsCollected();
    }
    public void AllFruitsCollected()
    {
        if (fruitsCollected.text.Equals("2"))
        {
            CanvasTime.SetActive(false);
            CanvasPuntos.SetActive(false);
            Debug.Log("No quedan frutas");
            transition.SetActive(true);
            ganador.SetActive(true);
            Invoke(nameof(ChangeScene), 1);

        }
    }

    void ChangeScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Time.timeScale = 0;
            ganador.SetActive(true);
        }
    }
}
