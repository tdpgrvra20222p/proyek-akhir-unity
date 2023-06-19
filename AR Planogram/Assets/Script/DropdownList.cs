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
    public GameObject parentObject;
    // void Awake()
    // {
    //     PopulateDropdownOptions();
    // }

    void Start()
    {
        PopulateDropdownOptions();
    }

    void PopulateDropdownOptions()
    {
        int childCount = parentObject.transform.childCount;
        List<GameObject> itemList = new List<GameObject>();

        for (int i = 0; i < childCount; i++)
        {
            GameObject childObject = parentObject.transform.GetChild(i).gameObject;
            itemList.Add(childObject);
        }

        List<string> fileNames = new List<string>();
        fileNames.Add("");
        // Extract the file names from the file paths
        foreach (GameObject item in itemList)
        {
            // Debug.Log(item.name);
            fileNames.Add(item.name);
        }

        dropdown.ClearOptions(); // Clear any existing options from the dropdown

        // Populate the dropdown options with the file names
        dropdown.AddOptions(fileNames);

        // Set the default selection to the first option
        dropdown.value = 0;
        dropdown.RefreshShownValue();
    }
 }
