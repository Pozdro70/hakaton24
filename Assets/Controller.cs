using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public Button Button; // Drag your button here in the inspector

    void Start()
    {
        // Ensure the button is assigned
        if (Button != null)
        {
            // Add a listener to the button to call LoadScene when clicked
            Button.onClick.AddListener(LoadScene);
        }
        else
        {
            Debug.LogError("Nie przypisano przycisku!");
        }
    }

    void LoadScene()
    {
        // Load the scene by name
        SceneManager.LoadScene("Poziom1"); // Replace with the name of your target scene
    }
}