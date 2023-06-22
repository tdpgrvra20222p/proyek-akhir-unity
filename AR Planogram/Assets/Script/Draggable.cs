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
            hitObject(hitInfo, objects);
            // if(hitInfo.transform.tag == destinationTag){
            //     transform.position = hitInfo.transform.position;

            //     Vector3 newPosition = transform.position;
            //     foreach (GameObject obj in objects)
            //     {
            //         if(transform.position == obj.transform.position){
            //             newPosition.z += 5f;
            //             transform.position = newPosition;
            //         }else{
            //             newPosition.z += 0f;
            //             transform.position = newPosition;
            //         }
            //     }
            //     addToParent(GameObject.Find("Rak"));
            // }else{
            //     transform.position = posisiSpawn.transform.position;
            // }
        }
        transform.GetComponent<Collider>().enabled = true;
        dropdown.value = 0;
    }

    private void addToParent(GameObject parentObject){
        transform.tag = "Placed";
        transform.SetParent(parentObject.transform);
    }

    private void hitObject(RaycastHit hitInfo,GameObject[] objects){
        if(hitInfo.transform.tag == "DropArea0"){
            if(GlobalValue.stak0 < 3){
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
                GlobalValue.stak0++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea1"){
            if(GlobalValue.stak1 < 3){
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
                GlobalValue.stak1++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea2"){
            if(GlobalValue.stak2 < 3){
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
                GlobalValue.stak2++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea3"){
            if(GlobalValue.stak3 < 3){
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
                GlobalValue.stak3++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea4"){
            if(GlobalValue.stak4 < 3){
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
                GlobalValue.stak4++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea5"){
            if(GlobalValue.stak5 < 3){
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
                GlobalValue.stak5++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea6"){
            if(GlobalValue.stak6 < 3){
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
                GlobalValue.stak6++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea7"){
            if(GlobalValue.stak7 < 3){
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
                GlobalValue.stak7++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea8"){
            if(GlobalValue.stak8 < 3){
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
                GlobalValue.stak8++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea9"){
            if(GlobalValue.stak9 < 3){
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
                GlobalValue.stak9++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea9"){
            if(GlobalValue.stak9 < 3){
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
                GlobalValue.stak9++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea10"){
            if(GlobalValue.stak10 < 3){
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
                GlobalValue.stak10++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea11"){
            if(GlobalValue.stak11 < 3){
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
                GlobalValue.stak11++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea12"){
            if(GlobalValue.stak12 < 3){
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
                GlobalValue.stak12++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea13"){
            if(GlobalValue.stak13 < 3){
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
                GlobalValue.stak13++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea14"){
            if(GlobalValue.stak14 < 3){
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
                GlobalValue.stak14++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else if(hitInfo.transform.tag == "DropArea15"){
            if(GlobalValue.stak15 < 3){
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
                GlobalValue.stak15++;
                addToParent(GameObject.Find("Rak"));
            }else{
                transform.position = posisiSpawn.transform.position;
            }
        }else{
            transform.position = posisiSpawn.transform.position;
        }
    }
 }
