using System.Collections;
using UnityEngine;

public class Asteroids : MonoBehaviour
{

    void Update()
    {
        transform.position -= new Vector3(0, 6 * Time.deltaTime, 0);
    
    
        if(transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
