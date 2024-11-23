using UnityEngine;
using UnityEngine.UI;

public class PlayerCore : MonoBehaviour
{
    public float hp;
    public float power;
    public Slider hpSlider;
    public Slider powerSlider;
    public static PlayerCore instance;
    public GameObject eogScreen;
    public bool god=false;
    void Start()
    {
        UpdatePlayerStats();
        instance = this;
        eogScreen.SetActive(false);
        power = 100;
        Movement.Instance.freezed = false;
    }

     
    public void UpdatePlayerStats()
    {
        hpSlider.value = hp;

        if(hp <= 0 && !god)
        {
            eogScreen.SetActive(true);
            Movement.Instance.freezed = true;
        }

        powerSlider.value = power;

        if(hp > hpSlider.maxValue) { hp = hpSlider.maxValue; }
        if(power > powerSlider.maxValue) { power = powerSlider.maxValue; }

    }

    

    void Update()
    {
        
    }
}
