using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OpenDoor : MonoBehaviour
{
    
    public int levelName;
    private bool inDoor = false;
    private float doorTime = 2.5f;
    private float startTime = 2.5f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
          
            inDoor = true;
            Debug.Log(inDoor);
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
        }else {
            Debug.Log("Puerta Bloqueada");
        }

        if(doorTime <= 0)
        {
            SceneManager.LoadScene(levelName);
        }

        if (inDoor && Input.GetKey("e")){
            SceneManager.LoadScene(1);
        }
    }
}
