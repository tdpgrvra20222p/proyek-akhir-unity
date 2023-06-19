using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class DropdownListPref : MonoBehaviour
{
     public TMP_Dropdown dropdown;
    void Start()
    {
        int LastestKey;

        if (PlayerPrefs.HasKey("LastestKey"))
        {
            LastestKey = PlayerPrefs.GetInt("LastestKey");
            
        }
        else
        {
            PlayerPrefs.SetInt("LastestKey", 0);
            PlayerPrefs.Save();
            LastestKey = 0;
        }

        List<string> keyNames = new List<string>();
        int no = 0;
        keyNames.Add("");
        for(int i=0; i<LastestKey; i++){
            no = no+1;
            keyNames.Add("Rak"+no);
        }
        dropdown.ClearOptions(); // Clear any existing options from the dropdown

        // Populate the dropdown options with the file names
        dropdown.AddOptions(keyNames);
        dropdown.value = 0;
        dropdown.RefreshShownValue();
    }
 }
