using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SkullCollected : MonoBehaviour
{
    public AudioSource clip;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Skull Collected");
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            //FindObjectOfType<FruitManager>().AllFruitsCollected();
            Destroy(gameObject, 0.5f);
            clip.Play();
        }
    }
}
