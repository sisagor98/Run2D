using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContoler : MonoBehaviour
{
    private float speed = 3f;
    // public GameObject jump;
    public Rigidbody2D rb;

    public Button jump;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }


    public void Jump()
    {
        rb.gravityScale *= -1;
        Vector3 temp = transform.localScale;
        temp.y *= -1;
        transform.localScale = temp;

    }

}
