using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // M�todo que se llama desde el evento onClick del bot�n
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}