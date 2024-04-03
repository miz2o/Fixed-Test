using UnityEngine;
using UnityEngine.UI;

public class SaveLoadUI : MonoBehaviour
{
    public GameObject saveLoadPanel;

    void Start()
    {
        saveLoadPanel.SetActive(false);
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
        saveLoadPanel.SetActive(!saveLoadPanel.activeSelf);
    }

    public void SaveButtonClicked()
    {
        SaveLoadManager.SaveGame();
    }

    public void LoadButtonClicked()
    {
        PlayerData data = SaveLoadManager.LoadGame();
        if (data != null)
        {
            // Implement loading logic here using the data retrieved from the save file
            // Example: playerTransform.position = data.playerPosition;
        }
    }
}

