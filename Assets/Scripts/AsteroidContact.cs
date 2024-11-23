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
            PlayerCore.instance.hp -= 20;
            PlayerCore.instance.UpdatePlayerStats();
            Destroy(other.gameObject);
        }
    }
}
