using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StateSwitcher : MonoBehaviour
{
    private WayCreator _wayCreator;
    private IState _currentState;
    private List<IState> _states;

    public void Init(WayCreator wayCreator)
    {
        _wayCreator = wayCreator;

        _states = new List<IState>
        {
            new IdleState(this, _wayCreator),
            new MoveState(this, transform, 2f, _wayCreator),
        };
        SwitchState<IdleState>();
    }

    private void Update()
    {
        _currentState.Update();
    }

    public void SwitchState<T>() where T : IState
    {
        var state = _states.FirstOrDefault(s => s is T);
        _currentState = state;
        state.Enter();
    }

        
}
