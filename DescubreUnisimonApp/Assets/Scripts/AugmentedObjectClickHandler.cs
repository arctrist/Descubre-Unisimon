using UnityEngine;

public class AugmentedObjectClickHandler : MonoBehaviour
{
    [SerializeField] private GameObject panelToActivate; // Assign your panel here

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " clicked!");

        if (panelToActivate != null)
        {
            panelToActivate.SetActive(true);
        }
    }
    private void Start()
    {
        if (panelToActivate != null)
        {
            panelToActivate.SetActive(false); // Hide panel at start
        }
    }
}