using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public Button btn_quit;
    // Start is called before the first frame update
    public void Start () {
        btn_quit.onClick.AddListener(AksiQuit);
    }
    public void AksiQuit () {
        Application.Quit();
    }
 }
