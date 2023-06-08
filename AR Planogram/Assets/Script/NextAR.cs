using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextAR : MonoBehaviour
{
    public Button btn_next;
    public GameObject movedObject;
    // Start is called before the first frame update
    public void Start () {
        btn_next.onClick.AddListener(AksiAR);
    }
    public void AksiAR () {
        SceneManager.LoadScene("ARScene");
        DontDestroyOnLoad(movedObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
