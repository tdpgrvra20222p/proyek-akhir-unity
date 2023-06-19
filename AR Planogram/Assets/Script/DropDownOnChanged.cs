using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DropDownOnChanged : MonoBehaviour
{
    
     public TMP_Dropdown dropdown;
    private GameObject CObject;
    public GameObject SpawnObject;

    private void Start()
    {
        // Register the callback method to the onValueChanged event of the Dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    // Method to be called when the Dropdown's value changes
    private void OnDropdownValueChanged(int value)
    {   
        string selectedOption = dropdown.options[value].text;
        Vector3 SpawnPosition = SpawnObject.transform.position;
        Debug.Log("Selected Option: " + selectedOption);
        
        CObject = GameObject.Find(selectedOption);
        GameObject clonedObject = Instantiate(CObject);
        // clonedObject.transform.position = new Vector3(-1.2693f, 0.09f, 0.097f);
        clonedObject.transform.position = SpawnPosition;
        // Add your desired logic here
    }
}
