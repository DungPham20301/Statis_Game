using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private Transform canvas;
    [SerializeField] private int columnLength;
    [SerializeField] private int rowLength;
    [SerializeField] private float x_Space;
    [SerializeField] private float y_Space;
    [SerializeField] private float x_Start;
    [SerializeField] private float y_Start;

    [SerializeField] GameObject bubblePrefab;

    private void Start()
    {
        for(int i = 0; i < columnLength * rowLength; i++)
        {
            var item =  Instantiate(bubblePrefab, new Vector3(x_Start + ( x_Space * (i % columnLength)), y_Start + (-y_Space * (i / columnLength))), Quaternion.identity);
            item.transform.SetParent(canvas);
        }
    }

}
