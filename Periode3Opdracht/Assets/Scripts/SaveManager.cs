using UnityEngine;
using UnityEngine.UI;

public class SaveLoadUI : MonoBehaviour
{
    public GameObject saveLoadPanel;
    public GameObject quitConfirmationPanel;
    public Button saveButton;
    public Button loadButton;

    void Start()
    {
        saveLoadPanel.SetActive(false);
        quitConfirmationPanel.SetActive(false);
        saveButton.gameObject.SetActive(false); // Hide save button initially
        loadButton.gameObject.SetActive(false); // Hide load button initially
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleSaveLoadMenu();
        }
    }

    public void ToggleSaveLoadMenu()
    {
        bool menuActive = !saveLoadPanel.activeSelf;
        saveLoadPanel.SetActive(menuActive);
        quitConfirmationPanel.SetActive(false); // Ensure quit confirmation panel is hidden

        // Toggle visibility of buttons based on menuActive
        saveButton.gameObject.SetActive(menuActive);
        loadButton.gameObject.SetActive(menuActive);
    }

    public void SaveButtonClicked()
    {
        // Handle save button click
        Debug.Log("Save button clicked");
    }

    public void LoadButtonClicked()
    {
        // Handle load button click
        Debug.Log("Load button clicked");
    }

    public void ShowQuitConfirmation()
    {
        quitConfirmationPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void CancelQuit()
    {
        quitConfirmationPanel.SetActive(false);
    }
}
