using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DropDownOnChangedPref : MonoBehaviour
{
    
    public TMP_Dropdown dropdown;
    // private GameObject CObject;
    public GameObject SpawnObject;
    private GameObject rakObject;
    
    private void Start()
    {
        // Register the callback method to the onValueChanged event of the Dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    // Method to be called when the Dropdown's value changes
    private void OnDropdownValueChanged(int value)
    {   
        string selectedOption = dropdown.options[value].text;

        // string serializedState = PlayerPrefs.GetString(selectedOption);

        // Vector3 loadedPosition = JsonUtility.FromJson<Vector3>(serializedState);
        // Vector3 SpawnPosition = SpawnObject.transform.position;
        // // SpawnPosition = loadedPosition;
        // string filePath = Path.Combine(Application.persistentDataPath, selectedOption+".dat");
        string LoadRak = PlayerPrefs.GetString("LoadRak");
        rakObject = GameObject.Find(selectedOption);
        rakObject.transform.position = new Vector3(-1.2693f, 0.09f, 0.097f);
        rakObject.transform.localScale = new Vector3(0.008f, 0.008f, 0.008f);
        PlayerPrefs.SetString("LoadRak",selectedOption);
        Debug.Log("Selected Option: " + selectedOption);

    }

    
}
