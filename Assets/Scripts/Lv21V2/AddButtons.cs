using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{

    [SerializeField] private Transform puzzleField;
    [SerializeField] private GameObject btn;

    private void Awake()
    {
        for(int i = 0; i < 12; i++)
        {
            GameObject button = Instantiate(btn, puzzleField, false);
            button.name = "" + i;
            //button.transform.SetParent(puzzleField, false);
        }
    }
}
