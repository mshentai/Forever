using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Lunar.Core.FSM
{
    public interface IStateMachine
    {
        void Init(object owner);
        void RegisterState(Type type);
        void RegisterState<T>() where T : IState, new();
        void ChangeState(Type type);
        void ChangeState<T>() where T : IState, new();
        void Run(Type type);
        void Run<T>() where T : IState, new();
        void Stop();
        void Update();
    }
}

