using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroidContact : MonoBehaviour
{
    public AnimationClip endAnim;
    public AudioSource audioSource;
    public AudioClip collectUpgrade;
    void Start()
    {

    }

    void Update()
    {

    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(1.4f);
        SceneManager.LoadScene("MainMenu");
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
            audioSource.PlayOneShot(collectUpgrade);

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
        else if (other.CompareTag("ending"))
        {
            gameObject.GetComponent<Animator>().Play(endAnim.name);

            SceneManager.LoadScene("MainMenu");
        }

    }
}
