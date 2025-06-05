using UnityEngine;
using UnityEngine.UI;

public class ImageTargetUIHandler : MonoBehaviour
{
    [SerializeField] private GameObject uiCanvas; // Drag your UI Canvas or Text GameObject here

    void Start()
    {
        if (uiCanvas != null)
            uiCanvas.SetActive(false); // Start hidden
    }

    public void OnTrackingFound()
    {
        Debug.Log("Image Target Found");
        if (uiCanvas != null)
            uiCanvas.SetActive(true);
    }

    public void OnTrackingLost()
    {
        Debug.Log("Image Target Lost");
        if (uiCanvas != null)
            uiCanvas.SetActive(false);
    }
}