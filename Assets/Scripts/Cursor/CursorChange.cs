//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.0
//     from Assets/Scripts/Cursor/CursorChange.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CursorChange: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CursorChange()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CursorChange"",
    ""maps"": [
        {
            ""name"": ""MouseAction"",
            ""id"": ""fbeff8a0-bf9c-4b1b-8e94-7f7a63cdba2e"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""a6416398-9546-4e97-9c1e-851d8867a7f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c5dd2030-d5e1-4f43-a0fc-068538b53bad"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseAction
        m_MouseAction = asset.FindActionMap("MouseAction", throwIfNotFound: true);
        m_MouseAction_Click = m_MouseAction.FindAction("Click", throwIfNotFound: true);
    }

    ~@CursorChange()
    {
        UnityEngine.Debug.Assert(!m_MouseAction.enabled, "This will cause a leak and performance issues, CursorChange.MouseAction.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // MouseAction
    private readonly InputActionMap m_MouseAction;
    private List<IMouseActionActions> m_MouseActionActionsCallbackInterfaces = new List<IMouseActionActions>();
    private readonly InputAction m_MouseAction_Click;
    public struct MouseActionActions
    {
        private @CursorChange m_Wrapper;
        public MouseActionActions(@CursorChange wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_MouseAction_Click;
        public InputActionMap Get() { return m_Wrapper.m_MouseAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActionActions set) { return set.Get(); }
        public void AddCallbacks(IMouseActionActions instance)
        {
            if (instance == null || m_Wrapper.m_MouseActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MouseActionActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
        }

        private void UnregisterCallbacks(IMouseActionActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
        }

        public void RemoveCallbacks(IMouseActionActions instance)
        {
            if (m_Wrapper.m_MouseActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMouseActionActions instance)
        {
            foreach (var item in m_Wrapper.m_MouseActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MouseActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MouseActionActions @MouseAction => new MouseActionActions(this);
    public interface IMouseActionActions
    {
        void OnClick(InputAction.CallbackContext context);
    }
}
