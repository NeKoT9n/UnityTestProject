
public class IdleState : IState
{
    private StateSwitcher _stateSwitcher;
    private WayCreator _wayCreator;
    public IdleState(StateSwitcher switcher, WayCreator creator)
    {
        _stateSwitcher = switcher;
        _wayCreator = creator;
    }

    public void Enter(){ }

    public void Update()
    {
        if (_wayCreator.HasFreeWay() == true)
            _stateSwitcher.SwitchState<MoveState>();
    }
}
