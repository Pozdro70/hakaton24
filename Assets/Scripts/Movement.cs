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
        //ranges
        if(transform.position.x >= range)
        {
            transform.position -= new Vector3(speed, 0, 0);
        }

        if (!(transform.position.x >= -range))
        {
            transform.position += new Vector3(speed, 0, 0);
        }




        //contorls
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed , 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed , 0, 0);
        }


    }
}
