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
    public GameObject dragon2;
    public GameObject starship;
    public GameObject ufo;
    public GameObject isp;
    public GameObject bhole;
    
    void Start()
    {
        StartCoroutine(spawnMeteroid());
    }
     int i = 0;
     int j = 0;
     int a = 0;
    bool notf = true;
    public bool infinite;
    int endVal;

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(1.4f);
    }

    IEnumerator spawnMeteroid()
    {
        if (infinite)
        {
            endVal = 999999999;
        }
        else
        {
            endVal = 2500;
        }

        Vector3 nextSpawnPosM = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 nextSpawnPosS = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 nextSpawnPosSy = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 hpUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 hpTUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 CSUpgradePosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 MoonPosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 dragon2PosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 starshipPosNext = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 ufoPos = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        Vector3 isPOs = new Vector3(Random.Range(-8.64f, 8.64f), 12, 0);
        
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

        if (TimeCore.instance.ATime > 1957 && TimeCore.instance.ATime < 1963)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(sputnikPrefab, nextSpawnPosS, Quaternion.Euler(180, 18, 0));

        }
        else if (TimeCore.instance.ATime > 1963 && TimeCore.instance.ATime < 1969)
        {

            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(soyuzPrefab, nextSpawnPosSy, Quaternion.Euler(180, -90, 0));
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
            TimeCore.instance.setTimeACC(1);
        }
        else if (TimeCore.instance.ATime > 2021 && TimeCore.instance.ATime < 2036)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(dragon2, dragon2PosNext, Quaternion.Euler(180, 0, 0));
            Instantiate(soyuzPrefab, nextSpawnPosSy, Quaternion.Euler(180, -90, 0));
            TimeCore.instance.setTimeACC(0.8f);
        }
        else if (TimeCore.instance.ATime > 2036 && TimeCore.instance.ATime < 2100)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(dragon2, dragon2PosNext, Quaternion.Euler(180, 0, 0));
            Instantiate(starship, starshipPosNext, Quaternion.Euler(180, 0, 0));
            TimeCore.instance.setTimeACC(0.6f);
        }
        else if (TimeCore.instance.ATime > 2100 && TimeCore.instance.ATime < 2300)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(starship, starshipPosNext, Quaternion.Euler(180, 0, 0));
            Instantiate(ufo, ufoPos, Quaternion.identity);
        }
        else if (TimeCore.instance.ATime > 2300 && TimeCore.instance.ATime < endVal)
        {
            Instantiate(meteorPrefab, nextSpawnPosM, Quaternion.identity);
            Instantiate(ufo, ufoPos, Quaternion.identity);
            Instantiate(isp, isPOs, Quaternion.Euler(90, 211, 0));
        }
        else if(TimeCore.instance.ATime >= 2500 && !infinite)
        {
            Instantiate(bhole, new Vector3(0,12,0), Quaternion.Euler(-33.281f,0, 14.961f));
            bhole = new GameObject();
            //StartCoroutine(EndGame());
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
