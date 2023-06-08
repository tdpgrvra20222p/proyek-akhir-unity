using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject username;
    public GameObject Password;
    public Button btn_login;
    // Start is called before the first frame update
    public void Start () {
        btn_login.onClick.AddListener(AksiLogin);
    }
    public void AksiLogin () {
        SceneManager.LoadScene("MenuUser");
    }
 }
