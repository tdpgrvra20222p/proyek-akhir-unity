using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallRak : MonoBehaviour
{
    public GameObject parentObject;
    private GameObject rakObject;
    private GameObject rakObjectInside;
    // Start is called before the first frame update
    void Awake()
    {
        string LoadRak = PlayerPrefs.GetString("LoadRak");
        rakObject = GameObject.Find(LoadRak);

        rakObjectInside = Instantiate(rakObject);
        rakObjectInside.transform.position = new Vector3(-1.2693f, 0.09f, 0.097f);
        rakObjectInside.transform.localScale = new Vector3(0.008f, 0.008f, 0.008f);
        rakObjectInside.transform.SetParent(parentObject.transform);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
