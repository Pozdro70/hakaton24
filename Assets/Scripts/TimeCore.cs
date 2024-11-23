using System.Collections;
using TMPro;
using UnityEngine;

public class TimeCore : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int ATime = 1957;
    public static TimeCore instance;
    void Start()
    {
        StartCoroutine(updateTime());
        instance = this;
    }

    IEnumerator updateTime()
    {
        timeText.text = ATime.ToString();
        ATime++;
        yield return new WaitForSeconds(1.4f);
        StartCoroutine(updateTime());
    }

    
    void Update()
    {
        
    }
}
