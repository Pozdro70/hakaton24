using System.Collections;
using TMPro;
using UnityEngine;

public class TimeCore : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public int ATime = 1957;
    void Start()
    {
        StartCoroutine(updateTime());
    }

    IEnumerator updateTime()
    {
        timeText.text = ATime.ToString();
        ATime++;
        yield return new WaitForSeconds(5);
        StartCoroutine(updateTime());
    }

    
    void Update()
    {
        
    }
}
