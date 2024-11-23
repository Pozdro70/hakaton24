using UnityEngine;

public class Settings : MonoBehaviour
{
    public bool hard, endless;
    public static Settings instance;
    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
