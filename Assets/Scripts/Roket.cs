using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roket : MonoBehaviour
{
    private float speeds = 2f;

    private void Update()
    {
        Vector2 temp = transform.position;
        temp.x -= speeds * Time.deltaTime;
        transform.position = temp;
    }




}
