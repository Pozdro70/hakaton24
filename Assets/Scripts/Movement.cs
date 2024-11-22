using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float range;
    void Start()
    {
        
    }


    void Update()
    {
        if (transform.position.x <= range && transform.position.x >= -range)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(speed, 0, 0);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-speed, 0, 0);
            }
        }
        else
        {
            transform.position -= new Vector3(0.01f, 0, 0);
        }
        
    }
}
