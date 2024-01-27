using UnityEngine.SceneManagement;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }


}