using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEditor;

public class NextARLoad : MonoBehaviour
{
    public Button btn_next;
    private GameObject movedObject;
    // Start is called before the first frame update
    public void Start () {
        btn_next.onClick.AddListener(AksiAR);
    }
    public void AksiAR () {
        SceneManager.LoadScene("ARScene");
      

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

        // string serializedState = JsonUtility.ToJson(movedObject.transform.position);

        // Save the serialized state to PlayerPrefs
        // LastestKey = LastestKey+1;
        // PlayerPrefs.SetInt("LastestKey", LastestKey);
        string LoadRak = PlayerPrefs.GetString("LoadRak");
        movedObject.name = LoadRak;
        // PlayerPrefs.SetString("LoadRak", movedObject.name );
        DontDestroyOnLoad(movedObject);
        // PlayerPrefs.SetString("Rak"+ LastestKey.ToString(), serializedState);
        // PlayerPrefs.Save();

        // GameObject prefab = PrefabUtility.SaveAsPrefabAsset(movedObject, Application.persistentDataPath+"/Rak"+LastestKey);

        // string filePath = Path.Combine(Application.persistentDataPath, "Rak"+LastestKey+".dat");
        // SaveGameObject(filePath, prefab);
    }
}
