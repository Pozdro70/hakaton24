using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public enum upgradeType{
        Hp,
        HpTotal,
        revertCtrls,
        clear
    }

    public upgradeType upgradet;

    void Update()
    {
        if (!Movement.Instance.freezed)
        {
            transform.position -= new Vector3(0, 6 * Time.deltaTime, 0);


            if (transform.position.y < -12)
            {
                Destroy(gameObject);
            }
        }
        


    }
}
