using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallRak : MonoBehaviour
{
    private GameObject rakObject;
    // Start is called before the first frame update
    void Start()
    {
        rakObject = GameObject.Find("Rak");
        rakObject.transform.position = new Vector3(-1.2693f, 0.09f, 0.097f);
        rakObject.transform.localScale = new Vector3(0.008f, 0.008f, 0.008f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
