using UnityEngine;
using UnityEngine.UI;

public class PlayerCore : MonoBehaviour
{
    public float hp;
    public Slider hpSlider;
    public static PlayerCore instance;
    void Start()
    {
        UpdatePlayerStats();
        instance = this;
    }

     
    public void UpdatePlayerStats()
    {
        hpSlider.value = hp;
    }

    void Update()
    {
        
    }
}
