using Lunar.Core;
using UnityEngine;
using System.Collections.Generic;
using System;

namespace Lunar.Core.FSM
{
    public class StateMachine : IStateMachine, ITickable
    {
        private object owner;
        private readonly Dictionary<Type, IState> states = new();
        private readonly Dictionary<string, object> blackboards = new();
        private IState currentState;
        private bool isRunning;
        public void Init(object owner)
        {
            this.owner = owner;
        }

        public void RegisterState(Type type)
        {
            LLog.Assert(type != null, "state is null");
            var state = Activator.CreateInstance(type) as IState;
            RegisterState(type, state);
        }

        public void RegisterState<T>() where T : IState, new()
        {
            var type = typeof(T);
            var state = new T();
            RegisterState(type, state);
        }

        private void RegisterState(Type type, IState state)
        {
            if (!this.states.TryAdd(type, state))
            {
                LLog.Error($"state <color=red>{type.Name}</color> is already registered");
            }
        }

        public void ChangeState(Type type)
        {
            LLog.Assert(type == null, "state is null");
            LLog.Assert(this.states.ContainsKey(type), "state is not registered");
            if (this.states.TryGetValue(type, out var newState))
            {
                this.currentState?.Exit();
                this.currentState = newState;
                this.currentState.Enter();
            }
        }

        public void ChangeState<T>() where T : IState, new()
        {
            var type = typeof(T);
            ChangeState(type);
        }

        public void Run(Type type)
        {
            if (!this.isRunning)
            {
                this.isRunning = true;
                ChangeState(type);
            }
        }

        public void Run<T>() where T : IState, new()
        {
            var type = typeof(T);
            Run(type);
        }

        public void Stop()
        {
            this.isRunning = false;
            this.currentState?.Exit();
            this.currentState = null;
        }

        public void Update()
        {
            this.currentState?.Update();
        }

        public void SetBlackBoardValue<T>(string key, T value)
        {
            this.blackboards[key] = value;
        }

        public T GetBlackBoardValue<T>(string key)
        {
            if (this.blackboards.TryGetValue(key, out var value))
            {
                return (T)value;
            }
            return default;
        }

        public bool TryGetBlackBoardValue<T>(string key, out T value)
        {

            if (this.blackboards.TryGetValue(key, out var v))
            {
                value = (T)v;
                return true;
            }
            value = default;
            return false;
        }
    }
}