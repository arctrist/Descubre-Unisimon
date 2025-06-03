using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Método que se llama desde el evento onClick del botón
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}