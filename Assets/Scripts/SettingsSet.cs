using UnityEngine;
using UnityEngine.UI;

public class SettingsSet : MonoBehaviour
{
    public Toggle hard, infinite;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void updateVar()
    {
        Settings.instance.endless = infinite.isOn;
        Settings.instance.hard = hard.isOn;
    }
}
