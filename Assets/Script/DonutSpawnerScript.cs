using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutSpawnerScript : MonoBehaviour
{
    public GameObject[] donutPrefabs;
    public float spawnInterval = 1.0f;
    float maxPos, minPos;
    Transform bakeryTransF;

   private void Start()
    {
        bakeryTransF = GetComponent<Transform>();
    }

    public void Bake(bool state)
    {
        if (state)
            StartCoroutine(Spawn());
        else
            StopAllCoroutines();
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            minPos = bakeryTransF.position.x - 40;
            maxPos = bakeryTransF.position.x + 40;
            var value = UnityEngine.Random.Range(minPos, maxPos);
            var pos = new Vector2(value, transform.position.y);
            GameObject donut = Instantiate(donutPrefabs[UnityEngine.Random.Range(0, donutPrefabs.Length)],
                pos, Quaternion.identity, bakeryTransF);
            yield return new WaitForSeconds(spawnInterval); 
        }
    }
}
