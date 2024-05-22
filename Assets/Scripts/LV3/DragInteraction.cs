using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragInteraction : MonoBehaviour
{
    //private Vector3 screenPoint;
    //private Vector3 startPosition;


    //private void OnMouseDown()
    //{
    //    startPosition= this.gameObject.transform.position;
    //    screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    //}

    //private void OnMouseDrag()
    //{
    //    Debug.Log("Can drag");
    //    Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
    //    Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
    //    this.transform.position = curPosition;
    //}

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld= false;

    private void Update()
    {
        if(isBeingHeld == true && CanMove())
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, 0, 0);
            //transform.position = new Vector3 (mousePos.x, 0 ,0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {

        isBeingHeld = false;

    }

    private bool CanMove()
    {
        if (transform.position.x >= -0.56f)
            return true;
        else
            return false;
    }
}
