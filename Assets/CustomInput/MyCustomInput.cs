// GENERATED AUTOMATICALLY FROM 'Assets/CustomInput/MyCustomInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MyCustomInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MyCustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MyCustomInput"",
    ""maps"": [
        {
            ""name"": ""New action map"",
            ""id"": ""90d94e7a-a8d1-42ba-98b7-dbb9c6293b71"",
            ""actions"": [
                {
                    ""name"": ""Set Direction"",
                    ""type"": ""Value"",
                    ""id"": ""4159c8a9-7a48-4e0f-8e50-cb2c8d9b3677"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""9ecc2cda-5587-482b-8fdb-146bd1c0bdac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Direction"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""87122182-ab83-42a9-9c23-5f1b4fd43808"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6986bd03-be2a-4c8e-a01b-dbc77daa2950"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""20b946ad-e0c8-4163-84ad-9aa305388d60"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2c60f643-fce9-4187-ae28-9c0acc24713c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Direction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // New action map
        m_Newactionmap = asset.FindActionMap("New action map", throwIfNotFound: true);
        m_Newactionmap_SetDirection = m_Newactionmap.FindAction("Set Direction", throwIfNotFound: true);
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

    // New action map
    private readonly InputActionMap m_Newactionmap;
    private INewactionmapActions m_NewactionmapActionsCallbackInterface;
    private readonly InputAction m_Newactionmap_SetDirection;
    public struct NewactionmapActions
    {
        private @MyCustomInput m_Wrapper;
        public NewactionmapActions(@MyCustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetDirection => m_Wrapper.m_Newactionmap_SetDirection;
        public InputActionMap Get() { return m_Wrapper.m_Newactionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewactionmapActions set) { return set.Get(); }
        public void SetCallbacks(INewactionmapActions instance)
        {
            if (m_Wrapper.m_NewactionmapActionsCallbackInterface != null)
            {
                @SetDirection.started -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnSetDirection;
                @SetDirection.performed -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnSetDirection;
                @SetDirection.canceled -= m_Wrapper.m_NewactionmapActionsCallbackInterface.OnSetDirection;
            }
            m_Wrapper.m_NewactionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SetDirection.started += instance.OnSetDirection;
                @SetDirection.performed += instance.OnSetDirection;
                @SetDirection.canceled += instance.OnSetDirection;
            }
        }
    }
    public NewactionmapActions @Newactionmap => new NewactionmapActions(this);
    public interface INewactionmapActions
    {
        void OnSetDirection(InputAction.CallbackContext context);
    }
}
