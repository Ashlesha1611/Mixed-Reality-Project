using UnityEngine;

public class ShowTextBox : MonoBehaviour
{
    public GameObject floatingTextBox; // Assign your Floating Text Box here

    void Start()
    {
        floatingTextBox.SetActive(true); // Show the text box immediately
    }
}
