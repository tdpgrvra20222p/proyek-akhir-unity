using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class DropdownList : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public string folderPath; // Path to the folder containing the files

    void Awake()
    {
        PopulateDropdownOptions();
    }

    void Start()
    {
        PopulateDropdownOptions();
    }

    void PopulateDropdownOptions()
    {
        string[] filePaths = Directory.GetFiles("/3D Model/"); // Get an array of file paths in the folder
        List<string> fileNames = new List<string>();
        
        // Extract the file names from the file paths
        foreach (string filePath in filePaths)
        {
            Debug.Log(filePath);
            string fileName = Path.GetFileName(filePath);
            fileNames.Add(fileName);
        }

        dropdown.ClearOptions(); // Clear any existing options from the dropdown

        // Populate the dropdown options with the file names
        dropdown.AddOptions(fileNames);

        // Set the default selection to the first option
        dropdown.value = 0;
        dropdown.RefreshShownValue();
    }
 }
