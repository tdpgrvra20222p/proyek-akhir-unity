using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLoadSaved : MonoBehaviour
{
    public Button btn_next_saved;
    // Start is called before the first frame update
    public void Start () {
        btn_next_saved.onClick.AddListener(AksiLoadSaved);
    }
    public void AksiLoadSaved () {
        SceneManager.LoadScene("LoadSaved");
    }
 }
