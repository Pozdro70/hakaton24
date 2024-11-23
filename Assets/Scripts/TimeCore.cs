using System.Collections;
using TMPro;
using UnityEngine;

public class TimeCore : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int ATime = 1957;
    public static TimeCore instance;
    public float timeAcc;
    void Start()
    {
        StartCoroutine(updateTime());
        instance = this;
        timeAcc = 1.4f;
    }

    IEnumerator updateTime()
    {
        timeText.text = ATime.ToString();
        ATime++;
        yield return new WaitForSeconds(timeAcc);

        if (!Movement.Instance.freezed)
        {
            StartCoroutine(updateTime());
        }
        
    }

    public void setTimeACC(float acc)
    {
        timeAcc = acc;
    }

    
    void Update()
    {
        
    }
}
