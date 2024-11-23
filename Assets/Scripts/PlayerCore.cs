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

        if(hp <= 0)
        {
            eogScreen.SetActive(true);
            Movement.Instance.freezed = true;
        }

        powerSlider.value = power;


    }

    

    void Update()
    {
        
    }
}
