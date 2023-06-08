using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextPlanning : MonoBehaviour
{
    public Button btn_planning;
    // Start is called before the first frame update
    public void Start () {
        btn_planning.onClick.AddListener(AksiPlanning);
    }
    public void AksiPlanning () {
        SceneManager.LoadScene("GenRack");
    }
 }
