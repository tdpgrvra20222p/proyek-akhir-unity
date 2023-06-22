using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

public class backGenRack : MonoBehaviour
{
    public Button btn_back;
    public string SceneName;
    // Start is called before the first frame update
    public void Start () {
        btn_back.onClick.AddListener(backScene);
    }
    public void backScene() {
        SceneManager.LoadScene(SceneName);
    }
}
