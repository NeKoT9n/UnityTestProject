using UnityEngine;

public class MoveState : IState
{
    private StateSwitcher _stateSwitcher;
    private Transform _transform;
    private float _speed;
    private Vector2 _target;
    private WayCreator _wayCreator;
    public MoveState(StateSwitcher switcher, Transform transform, float speed, WayCreator creator)
    {
        _stateSwitcher = switcher;
        _transform = transform;
        _speed = speed;
        _wayCreator = creator;
    }

    public void Enter()
    {
        _target = _wayCreator.GetFreeWay();
    }

    public void Update()
    {
        _transform.position = Vector2.MoveTowards(_transform.position, _target, _speed * Time.deltaTime);
        if ((Vector2)_transform.position == _target)
            _stateSwitcher.SwitchState<IdleState>();
    }
}
