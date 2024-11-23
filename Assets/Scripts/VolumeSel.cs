using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSel : MonoBehaviour
{
    public Slider volume;
    public AudioMixer mixer;
    void Start()
    {
        
    }

    public void updateVolume()
    {
        mixer.SetFloat("volume", volume.value);
    }

    void Update()
    {
        
    }
}
