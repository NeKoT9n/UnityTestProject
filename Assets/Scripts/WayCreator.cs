using System.Collections.Generic;
using UnityEngine;

public class WayCreator 
{
    private ClickCatcher _clickCatcher;
    private List<Vector2> _wayPoints;

    public WayCreator(ClickCatcher catcher)
    {
        _clickCatcher = catcher;
        _wayPoints = new List<Vector2>();
        _clickCatcher.OnClick += AddPoint;
    }

    private void AddPoint(Vector2 point)
    {
        _wayPoints.Add(point);
    }

    public Vector2 GetFreeWay()
    {
        var point = _wayPoints[0];
        _wayPoints.RemoveAt(0);
        return point;
    }

    public bool HasFreeWay() => _wayPoints.Count != 0; 


}
