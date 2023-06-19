using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Draggable : MonoBehaviour
{
    public delegate void DragEndedDelegate(Draggable draggableObjects);
    
    public DragEndedDelegate dragEndedCallback;
    public GameObject parentObject;
    public GameObject posisiSpawn;
    // private bool isDragging = false;
    public string destinationTag = "DropArea";
    // Vector3 mouseDragStartPosition;
    Vector3 offset;
    // Vector3 spriteDragStartPosition;

    public TMP_Dropdown dropdown;

    private Vector3 GetMousePosition(){
        var mousScreenPos = Input.mousePosition;
        mousScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mousScreenPos);
    }
    private void OnMouseDown()
    {
        // isDragging = true;
        // mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // spriteDragStartPosition = transform.localPosition;

        offset = transform.position - GetMousePosition();
        transform.GetComponent<Collider>().enabled = false;
    }


    private void OnMouseDrag()
    {
        transform.position = GetMousePosition() + offset;
        // if(isDragging){
        //     // transform.localPosition = spriteDragStartPosition + (Camera.main.ScreenToWorldPoint(Input.mousePosition) - mouseDragStartPosition);
        //     transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mouseDragStartPosition);

        // }
        
    }
    

    private void OnMouseUp()
    {
        var rayOrigin = Camera.main.transform.position;
        var rayDirection = GetMousePosition() - Camera.main.transform.position;
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Placed");
        RaycastHit hitInfo;
        if(Physics.Raycast(rayOrigin,rayDirection, out hitInfo)){
            if(hitInfo.transform.tag == destinationTag){
                transform.position = hitInfo.transform.position;

                Vector3 newPosition = transform.position;
                foreach (GameObject obj in objects)
                {
                    if(transform.position == obj.transform.position){
                        newPosition.z += 5f;
                        transform.position = newPosition;
                    }else{
                        newPosition.z += 0f;
                        transform.position = newPosition;
                    }
                }
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }
        transform.GetComponent<Collider>().enabled = true;
        dropdown.value = 0;
    }

    private void addToParent(GameObject parentObject){
        transform.tag = "Placed";
        transform.SetParent(parentObject.transform);
    }
 }
