//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/FPControls.inputactions
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

public partial class @FPControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPControls"",
    ""maps"": [
        {
            ""name"": ""Gamplay Controls"",
            ""id"": ""6bfc4a0a-f3c0-40ab-98f5-936ac60ca3da"",
            ""actions"": [
                {
                    ""name"": ""CameraLook"",
                    ""type"": ""Value"",
                    ""id"": ""89167fe2-8636-4a6f-a1de-0b5ec4834375"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerMove"",
                    ""type"": ""Value"",
                    ""id"": ""c4d23e2d-d1b2-4b10-a0aa-d0724bdcc845"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2c4d8e8b-192e-4c6d-8225-53d992520861"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""CameraLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""3f056a32-aad2-469a-84da-788455622f31"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""d4c055bb-9e5d-43ad-b1d2-4cfac78d1d1e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""f510b945-6f9f-448b-a971-15fc6d87f125"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""2b927a37-8e4d-42d8-90ce-1600204e6c0d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""f8d7c260-4143-46a7-87d5-88e619de86c5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""db4b46d9-3e91-4148-8097-408f18c781dd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""73a64232-e387-4d75-b10d-66681ab61a27"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""f6fee3cc-0da8-4870-b184-a82a6a1e5ff8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""045bee57-401e-4bcd-9e80-e5b81d0aa8f4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""b54c8027-2de2-4004-b908-439e35072930"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""PlayerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gamplay Controls
        m_GamplayControls = asset.FindActionMap("Gamplay Controls", throwIfNotFound: true);
        m_GamplayControls_CameraLook = m_GamplayControls.FindAction("CameraLook", throwIfNotFound: true);
        m_GamplayControls_PlayerMove = m_GamplayControls.FindAction("PlayerMove", throwIfNotFound: true);
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

    // Gamplay Controls
    private readonly InputActionMap m_GamplayControls;
    private List<IGamplayControlsActions> m_GamplayControlsActionsCallbackInterfaces = new List<IGamplayControlsActions>();
    private readonly InputAction m_GamplayControls_CameraLook;
    private readonly InputAction m_GamplayControls_PlayerMove;
    public struct GamplayControlsActions
    {
        private @FPControls m_Wrapper;
        public GamplayControlsActions(@FPControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraLook => m_Wrapper.m_GamplayControls_CameraLook;
        public InputAction @PlayerMove => m_Wrapper.m_GamplayControls_PlayerMove;
        public InputActionMap Get() { return m_Wrapper.m_GamplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamplayControlsActions set) { return set.Get(); }
        public void AddCallbacks(IGamplayControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_GamplayControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GamplayControlsActionsCallbackInterfaces.Add(instance);
            @CameraLook.started += instance.OnCameraLook;
            @CameraLook.performed += instance.OnCameraLook;
            @CameraLook.canceled += instance.OnCameraLook;
            @PlayerMove.started += instance.OnPlayerMove;
            @PlayerMove.performed += instance.OnPlayerMove;
            @PlayerMove.canceled += instance.OnPlayerMove;
        }

        private void UnregisterCallbacks(IGamplayControlsActions instance)
        {
            @CameraLook.started -= instance.OnCameraLook;
            @CameraLook.performed -= instance.OnCameraLook;
            @CameraLook.canceled -= instance.OnCameraLook;
            @PlayerMove.started -= instance.OnPlayerMove;
            @PlayerMove.performed -= instance.OnPlayerMove;
            @PlayerMove.canceled -= instance.OnPlayerMove;
        }

        public void RemoveCallbacks(IGamplayControlsActions instance)
        {
            if (m_Wrapper.m_GamplayControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGamplayControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_GamplayControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GamplayControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GamplayControlsActions @GamplayControls => new GamplayControlsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IGamplayControlsActions
    {
        void OnCameraLook(InputAction.CallbackContext context);
        void OnPlayerMove(InputAction.CallbackContext context);
    }
}
