using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerMoveHandler
{
    [SerializeField] private Image img;

    private bool isClick;
    private int pointID;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(pointID != -1)
            return;
        pointID = eventData.pointerId;
        isClick = true;
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        if (isClick)
        {

        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if(pointID != eventData.pointerId)
            return;

        pointID = -1;
        isClick = false;
    }
}
