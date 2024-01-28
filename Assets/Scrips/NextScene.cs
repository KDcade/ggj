using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
     public void Resart()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = false;
         Cursor.lockState = CursorLockMode.Locked;

    }
    public void Dead()
    {
        SceneManager.LoadScene(5);
         Cursor.visible = true;
         Cursor.lockState = CursorLockMode.None;

    }

}