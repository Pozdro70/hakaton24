using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnCtrl : MonoBehaviour
{
    public void respawn()
    {
        SceneManager.LoadScene("Game");
    }

}
