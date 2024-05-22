using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private bool _dragging, _placed;

    private Vector2 _offset, _originalPosition;

    
    private PuzzleSlot _slot;

    private int count = 0;

    public void Init(PuzzleSlot slot)
    {
        _renderer.color = slot.Renderer.color;
        _slot = slot;
    }

    private void Awake()
    {
        _originalPosition = transform.position;
    }


    private void Update()
    {
        if (_placed)
            return;
        if(!_dragging)
            return;

        var mousePosition = GetMousePos();

        transform.position = mousePosition - _offset;

        Debug.Log("Count: " + count);
    }

    private void OnMouseDown()
    {

        _dragging = true;

        _offset = GetMousePos() - (Vector2)transform.position;
    }

    private void OnMouseUp()
    {
        if (Vector2.Distance(transform.position, _slot.transform.position) < .5)
        {
            transform.position = _slot.transform.position;
            _placed = true;
            count++;
        }
        else
        {
            transform.position = _originalPosition;
            _dragging = false;

        }
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
