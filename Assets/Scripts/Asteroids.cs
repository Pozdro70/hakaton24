using System.Collections;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(lifetime());
    }

    IEnumerator lifetime()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

    void Update()
    {
        transform.position -= new Vector3(0, 0.01f, 0);
    }
}
