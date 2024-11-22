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
        float randPos = 0;
        randPos = Random.Range(0,8.64f*2);
        Transform nextSpawnPos = new GameObject().transform;
        nextSpawnPos.position = new Vector3(randPos, 0, 0);

        Instantiate(meteorPrefab, nextSpawnPos);

        yield return new WaitForSeconds(0.4f);

        StartCoroutine(spawnMeteroid());
    }
    void Update()
    {
       

    }

    
}
