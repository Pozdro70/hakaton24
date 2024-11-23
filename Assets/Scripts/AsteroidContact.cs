using UnityEngine;

public class AsteroidContact : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("obstacle"))
        {
            PlayerCore.instance.hp -= 10;
            PlayerCore.instance.UpdatePlayerStats();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("upgrade"))
        {
            if (other.GetComponent<Upgrade>().upgradet == Upgrade.upgradeType.Hp)
            {
                
                PlayerCore.instance.hp += 10;
                
            }
            if (other.GetComponent<Upgrade>().upgradet == Upgrade.upgradeType.HpTotal)
            {
                
                PlayerCore.instance.hpSlider.maxValue += 50;
            }
            if (other.GetComponent<Upgrade>().upgradet == Upgrade.upgradeType.clear)
            {
                for (int i = 0; i < FindObjectsByType<Asteroids>(FindObjectsSortMode.None).Length; i++)
                {
                    Destroy(FindObjectsByType<Asteroids>(FindObjectsSortMode.None)[i].gameObject);
                }

            }
            Destroy(other.gameObject);
            PlayerCore.instance.UpdatePlayerStats();
        }

    }
}
