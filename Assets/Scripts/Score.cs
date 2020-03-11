using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoretest;
    private int score = 0;
    private int life;

    private void Start()
    {
        life = 3;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "coin")
        {
            score++;
            scoretest.text = score.ToString();
            other.gameObject.SetActive(false);
        }
        if(other.tag == "Bullet")
        {
            other.gameObject.SetActive(false);
            life--;
            if(life == 0)
            {
                ReStart();
            }
        }
        
    }

    void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
