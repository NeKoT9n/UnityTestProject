using System;
using UnityEngine;

public class ClickCatcher : MonoBehaviour
{
    private Camera _mainCamera;

    public Action<Vector2> OnClick;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void OnMouseDown()
    {
        Vector2 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
        OnClick?.Invoke(mousePosition);
    }
}
