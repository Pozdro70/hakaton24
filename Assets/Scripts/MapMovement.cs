using System.Linq.Expressions;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    void Update()
    {
        if (!Movement.Instance.freezed)
        {
            transform.position -= new Vector3(0, 0.3f * Time.deltaTime, 0);

            if (transform.position.y <= -4)
            {
                transform.position = new Vector3(0, 4, 0);
            }
        }
        
    }
}
