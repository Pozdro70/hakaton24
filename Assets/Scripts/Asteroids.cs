using System.Collections;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public int speed = 6;

    void Update()
    {
        if (!Movement.Instance.freezed)
        {
            transform.position -= new Vector3(0, speed * Time.deltaTime, 0);

            if (transform.position.y < -12)
            {
                Destroy(gameObject);
            }
        }
        
    }
}
