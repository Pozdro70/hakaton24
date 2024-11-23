using System.Linq.Expressions;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(0, 0.3f*Time.deltaTime, 0);

    }
}
