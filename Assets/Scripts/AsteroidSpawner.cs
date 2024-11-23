using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject sputnikPrefab;
    void Start()
    {
        StartCoroutine(spawnMeteroid());
    }

    IEnumerator spawnMeteroid()
    {
        Vector3 nextSpawnPosM = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 nextSpawnPosS = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        if (TimeCore.instance.ATime > 1957)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(sputnikPrefab, nextSpawnPosS, Quaternion.Euler(180, 18, 0));
        }
        

        yield return new WaitForSeconds(0.4f);

        StartCoroutine(spawnMeteroid());
    }
    void Update()
    {
       

    }

    
}
