using UnityEngine;
using UnityEngine.UI;

public class ButtonScaler : MonoBehaviour
{
    public Button button;
    public Vector3 scaleUpSize = new Vector3(1.2f, 1.2f, 1.2f); // Scale factor when pressed
    private Vector3 originalScale;

    void Start()
    {
        if (button == null)
            button = GetComponent<Button>();

        originalScale = transform.localScale;

        // Add listener to the button click
        button.onClick.AddListener(() => OnButtonClick());
    }

    void OnButtonClick()
    {
        // Change the scale of the button
        transform.localScale = scaleUpSize;

        // Optionally reset the scale after a short delay
        Invoke("ResetScale", 0.2f);
    }

    void ResetScale()
    {
        transform.localScale = originalScale;
    }
}