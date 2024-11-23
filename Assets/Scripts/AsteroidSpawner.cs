using System.Collections;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject soyuzPrefab;
    public GameObject sputnikPrefab;
    public GameObject upgradeHP;
    public GameObject upgradeTHP;
    public GameObject upgradeCS;
    public GameObject moon;
    void Start()
    {
        StartCoroutine(spawnMeteroid());
    }
     int i = 0;
     int j = 0;
     int a = 0;
    IEnumerator spawnMeteroid()
    {
        Vector3 nextSpawnPosM = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 nextSpawnPosS = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 nextSpawnPosSy = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 hpUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 hpTUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 CSUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 MoonPosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        
        if (i == 10)
        {
            Instantiate(upgradeHP, hpUpgradePosNext, Quaternion.identity);
            i = 0;
        }

        i++;

        if (j == 60)
        {
            Instantiate(upgradeTHP, hpTUpgradePosNext, Quaternion.identity);
            j = 0;
        }

        j++;

        if (a == 25)
        {
            Instantiate(upgradeCS, CSUpgradePosNext, Quaternion.identity);
            a = 0;
        }

        a++;

        if (TimeCore.instance.ATime > 1957 && TimeCore.instance.ATime <1963)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(sputnikPrefab, nextSpawnPosS, Quaternion.Euler(180, 18, 0));
            
        }
        else if (TimeCore.instance.ATime > 1963 && TimeCore.instance.ATime < 1969)
        {
            
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(soyuzPrefab, nextSpawnPosSy, Quaternion.Euler(180,-90,0));
        }
        else if (TimeCore.instance.ATime > 1969 && TimeCore.instance.ATime < 1978)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(moon, MoonPosNext, Quaternion.identity);
        }
        else if (TimeCore.instance.ATime > 1978 && TimeCore.instance.ATime < 2021)
        {

            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(soyuzPrefab, nextSpawnPosSy, Quaternion.Euler(180, -90, 0));
        }

        yield return new WaitForSeconds(0.4f);

        if (!Movement.Instance.freezed)
        {
            StartCoroutine(spawnMeteroid());
        }

    }
    void Update()
    {
       

    }

    
}
