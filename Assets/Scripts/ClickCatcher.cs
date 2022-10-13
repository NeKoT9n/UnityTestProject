using System;
using UnityEngine;

public class ClickCatcher : MonoBehaviour
{
    public Action<Vector2> OnClick;

    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void OnMouseDown()
    {
        Vector2 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePosition);
        OnClick?.Invoke(mousePosition);
    }
}
