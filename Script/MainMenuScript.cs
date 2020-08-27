
using UnityEngine;

using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public static bool isLoading = false;

    public void NewGame()
    {
        SceneManager.LoadScene(1);


    }
    public void loadGame()
    {
        isLoading = true;
        SceneManager.LoadScene(1);
    }
}
