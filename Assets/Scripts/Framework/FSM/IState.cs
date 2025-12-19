using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lunar.Core.FSM
{
    public interface IState
    {
        void OnInit(IStateMachine stateMachine);
        void OnEnter();
        void OnExit();
        void OnUpdate();
    }
}

