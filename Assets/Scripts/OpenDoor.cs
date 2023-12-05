using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OpenDoor : MonoBehaviour
{

    public int levelName;
    public GameObject puertaA;
    public GameObject puertaB;
    private bool inDoor = false;
    private float doorTime = 2.5f;
    private float startTime = 2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (ContadorNiveles.Instance.GetNivelesC() >= levelName)
            {
                inDoor = true;
                puertaB.gameObject.SetActive(false);
                puertaA.gameObject.SetActive(true);
                Debug.Log(inDoor);

            }else{
                puertaA.gameObject.SetActive(false);
                puertaB.gameObject.SetActive(true);
                Debug.Log("Puerta Bloqueada");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        inDoor = false;

        doorTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (inDoor && ContadorNiveles.Instance.GetNivelesC() >= levelName)
        {
            doorTime -= Time.deltaTime;
        }

        if (doorTime <= 0)
        {
            SceneManager.LoadScene(levelName);
        }

        if (inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
