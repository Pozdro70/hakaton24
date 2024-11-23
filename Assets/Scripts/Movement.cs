using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;
    public float range;
    public float sOfset;
    public bool freezed;
    public static Movement Instance;
    void Start()
    {
        Instance = this;
    }


    void Update()
    {
        if (!freezed)
        {
            //ranges
            if (transform.position.x >= range)
            {
                transform.position -= new Vector3(speed * sOfset, 0, 0);
            }

            if (!(transform.position.x >= -range))
            {
                transform.position += new Vector3(speed * sOfset, 0, 0);
            }


            //contorls
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
                transform.eulerAngles = new Vector3(0, 45, -90);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
                transform.eulerAngles = new Vector3(0, 135, -90);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 90, -90);
            }

            if (Input.GetKey(KeyCode.RightShift) && PlayerCore.instance.power>2)
            {
                PlayerCore.instance.power -= 0.1f;
                PlayerCore.instance.UpdatePlayerStats();

                speed = 12;
            }
            else
            {
                speed = 6;
                PlayerCore.instance.power += 0.1f;
                PlayerCore.instance.UpdatePlayerStats();
            }
        }
        

    }
}
