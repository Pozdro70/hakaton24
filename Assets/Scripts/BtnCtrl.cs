using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnCtrl : MonoBehaviour
{
    public Animator animator;
    public AnimationClip settingsS;
    public AnimationClip settingsD;
    public void respawn()
    {
        SceneManager.LoadScene("Game");
    }

    public void quit()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void settings()
    {
        animator.Play(settingsS.name);
    }

    public void mainMenuFromMM()
    {
        animator.Play(settingsD.name);
    }

}
