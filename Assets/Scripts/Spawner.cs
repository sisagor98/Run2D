using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] item;
    private int score = 0;

    private float minY = -2.5f, maxY = 2.5f;
    void Start()
    {
        StartCoroutine(SpawnItems(1f));
    }
    IEnumerator SpawnItems(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Vector3 temp = new Vector3(transform.position.x, Random.Range(minY, maxY), 0);
        Instantiate(item[Random.Range(0, item.Length)], temp, Quaternion.identity);
        StartCoroutine(SpawnItems(Random.Range(1f, 2f)));
    }




}
