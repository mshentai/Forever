using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lunar.Core.FSM
{
    public interface IState
    {
        void Init(IStateMachine stateMachine);
        void Enter();
        void Exit();
        void Update();
    }
}

