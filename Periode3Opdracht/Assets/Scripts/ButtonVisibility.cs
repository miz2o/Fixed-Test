using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject saveButton;
    public GameObject loadButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleButtons();
        }
    }

    void ToggleButtons()
    {
        saveButton.SetActive(!saveButton.activeSelf);
        loadButton.SetActive(!loadButton.activeSelf);
    }
}
