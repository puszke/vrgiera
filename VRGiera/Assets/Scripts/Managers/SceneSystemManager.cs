using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystemManager : MonoBehaviour
{
    public static SceneSystemManager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(Instance);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

}
