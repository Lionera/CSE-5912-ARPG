//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Scripts/Controllers/InputActions.inputactions
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

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""PauseMen"",
            ""id"": ""7e3b0055-a70b-4316-bb6d-415a5bb66dfd"",
            ""actions"": [
                {
                    ""name"": ""pause"",
                    ""type"": ""Button"",
                    ""id"": ""b4b8f339-b223-442e-adbf-ae35c2d2ee7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a790b4c4-5001-4af3-b5ef-66841556ace6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PauseMen
        m_PauseMen = asset.FindActionMap("PauseMen", throwIfNotFound: true);
        m_PauseMen_pause = m_PauseMen.FindAction("pause", throwIfNotFound: true);
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

    // PauseMen
    private readonly InputActionMap m_PauseMen;
    private IPauseMenActions m_PauseMenActionsCallbackInterface;
    private readonly InputAction m_PauseMen_pause;
    public struct PauseMenActions
    {
        private @InputActions m_Wrapper;
        public PauseMenActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @pause => m_Wrapper.m_PauseMen_pause;
        public InputActionMap Get() { return m_Wrapper.m_PauseMen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenActions instance)
        {
            if (m_Wrapper.m_PauseMenActionsCallbackInterface != null)
            {
                @pause.started -= m_Wrapper.m_PauseMenActionsCallbackInterface.OnPause;
                @pause.performed -= m_Wrapper.m_PauseMenActionsCallbackInterface.OnPause;
                @pause.canceled -= m_Wrapper.m_PauseMenActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PauseMenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @pause.started += instance.OnPause;
                @pause.performed += instance.OnPause;
                @pause.canceled += instance.OnPause;
            }
        }
    }
    public PauseMenActions @PauseMen => new PauseMenActions(this);
    public interface IPauseMenActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
