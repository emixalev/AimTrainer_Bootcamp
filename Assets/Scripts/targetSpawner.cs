using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class targetSpawner : MonoBehaviour
{
    public float respawnTime = 1.0f;
    public GameObject target;
    public float targetAmount;

    private void Start()
    {
        StartCoroutine(TargetSpawnerFunc());
    }
    private void Update()
    {
        targetAmount = GameObject.FindGameObjectsWithTag("Target").Length;
    }
    private void SpawnTargets()
    {
        GameObject a = Instantiate(target) as GameObject;
        a.transform.position = new Vector3(Random.Range(-36, -12), Random.Range(1, 10), Random.Range(-22, 17));
    }
    IEnumerator TargetSpawnerFunc() 
    {
       while(true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnTargets();
        }
    }
}
