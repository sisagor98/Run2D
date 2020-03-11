using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoy : MonoBehaviour
{

    private float width = 2.33f;

    void Start()
    {
        //width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log("fakjhfa");
        if (other.tag == "Bg" || other.tag == "Ground")
        {
            Vector3 temp = other.transform.position;
            temp.x += width *4;
            other.transform.position = temp;
        }

        if(other.tag =="coin" || other.tag == "Bullet")
        {
            other.gameObject.SetActive(false);

        }
    }
}
