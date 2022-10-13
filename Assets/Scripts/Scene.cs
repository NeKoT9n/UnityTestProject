using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void RestartScene()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
