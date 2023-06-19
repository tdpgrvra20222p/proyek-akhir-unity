using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

public class NextARSaved : MonoBehaviour
{
    public Button btn_next;
    public GameObject movedObject;
    // Start is called before the first frame update
    public void Start () {
        btn_next.onClick.AddListener(AksiAR);
    }
    public void AksiAR () {
        SceneManager.LoadScene("ARScene");
    }
}
