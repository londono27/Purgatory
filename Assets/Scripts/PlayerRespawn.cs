using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
    public static PlayerRespawn Instance;
    public GameObject[] hearts;
    private int life;
    private float checkPointPositionX, checkPointPositionY;
    public Animator animator;
    private void Awake()
    {
        Instance = this;
    }
        private void Start()
    {
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }

    private void CheckLife()
    {
        if (life < 1)
        {
            Destroy(hearts[0]);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            animator.Play("Hit");
        }
        else if (life < 2)
        {
            Destroy(hearts[1]);
            animator.Play("Hit");
        }
        else if (life < 3)
        {
            Destroy(hearts[2]);
            animator.Play("Hit");
        }
    }

    public void PlayerDamaged()
    {
        life--;
        CheckLife();
    }
    public void PlayerDamagedFinal(float presiona)
    {
        if(presiona<0){
            SceneManager.LoadScene(0);
        }else{
            life -= 3;
            CheckLife();
        }
    }
}
