using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    void Start()
    {
        StartCoroutine(spawnMeteroid());
    }

    IEnumerator spawnMeteroid()
    {
        Vector3 nextSpawnPos = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);

        Instantiate(meteorPrefab, nextSpawnPos, Quaternion.identity);

        yield return new WaitForSeconds(0.4f);

        StartCoroutine(spawnMeteroid());
    }
    void Update()
    {
       

    }

    
}
