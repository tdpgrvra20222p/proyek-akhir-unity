using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallRak : MonoBehaviour
{
    public GameObject parentObject;
    private GameObject rakObject;
    private GameObject rakObjectOther;
    private GameObject rakObjectInside;
    private int LastestKey;
    // Start is called before the first frame update
    void Awake()
    {
        

        string LoadRak = PlayerPrefs.GetString("LoadRak");
        rakObject = GameObject.Find(LoadRak);
        // rakObject.GetComponent<Renderer>().enabled = true;

        rakObjectInside = Instantiate(rakObject);
        rakObjectInside.transform.position = new Vector3(-1.2693f, 0.09f, 0.097f);
        rakObjectInside.transform.localScale = new Vector3(0.008f, 0.008f, 0.008f);
        rakObjectInside.transform.SetParent(parentObject.transform);
        
        LastestKey = PlayerPrefs.GetInt("LastestKey");
        for(int i=1; i<=LastestKey; i++){
            Debug.Log(i);
            rakObjectOther = GameObject.Find("Rak"+i);
            rakObjectOther.transform.position = new Vector3(-0.714f, 0.177f, -30f);
            rakObjectOther.transform.localScale = new Vector3(0.0001f, 0.0001f, 0.0001f);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
