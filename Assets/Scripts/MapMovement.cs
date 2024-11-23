using System.Linq.Expressions;
using UnityEngine;

public class MapMovement : MonoBehaviour
{
    public Sprite I_AGE;
    public Sprite II_AGE;
    public Sprite III_AGE;
    void Update()
    {
        if (!Movement.Instance.freezed)
        {
            transform.position -= new Vector3(0, 0.3f * Time.deltaTime, 0);

            if (transform.position.y <= -4)
            {
                transform.position = new Vector3(0, 4, 0);
            }

            if (TimeCore.instance.ATime > 1957 && TimeCore.instance.ATime < 1969)
            {
                GetComponent<SpriteRenderer>().sprite = I_AGE;
            }
            else if (TimeCore.instance.ATime > 1969 && TimeCore.instance.ATime < 2021)
            {
                GetComponent<SpriteRenderer>().sprite = II_AGE;
            }
            else if (TimeCore.instance.ATime > 2021)
            {
                GetComponent<SpriteRenderer>().sprite = III_AGE;
            }
        }
        
        
    }
}
