using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SaveLoadManager : MonoBehaviour
{
    public TMP_InputField inputField;



    // Function to save the game
    public void SaveGame()
    {
        if (inputField == null)
        {
            Debug.LogError("inputField is null!");
            return;
        }

        // Save player position
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);

        PlayerPrefs.SetString("Input", inputField.text);

        // Save PlayerPrefs to disk
        PlayerPrefs.Save();
    }



    // Function to load the game
    public void LoadGame()
    {
        if (inputField == null)
        {
            Debug.LogError("inputField is null!");
            return;
        }

        // Load player position
        float playerX = PlayerPrefs.GetFloat("PlayerX");
        float playerY = PlayerPrefs.GetFloat("PlayerY");
        float playerZ = PlayerPrefs.GetFloat("PlayerZ");
        transform.position = new Vector3(playerX, playerY, playerZ);



        inputField.text = PlayerPrefs.GetString("Input");
    }
}
