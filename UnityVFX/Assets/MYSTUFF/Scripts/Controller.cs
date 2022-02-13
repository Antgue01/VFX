// GENERATED AUTOMATICALLY FROM 'Assets/MYSTUFF/Scripts/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controller : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""d70b8ce3-6815-4295-a841-450d19d871ab"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""70942d59-ad7e-4e7d-83db-8fe54f65082f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""bc586f86-1d04-4225-8068-6a2c6ef5137b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Axis"",
                    ""id"": ""ac96d854-18bb-4899-8ba7-1ff78825f11a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""37275bb4-8559-425a-9cc7-b142734ce8b1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""caafca88-95db-4418-9292-d59f065206c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""b024f13d-adda-46ab-b6d1-818e3b9b91cf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1a4af842-4cad-4097-b489-d94e66d48b6e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8504b26f-ec22-4e2b-8489-13927d7afcd4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Cam"",
            ""id"": ""1a0e8769-0ebf-40c6-a1c5-f792acc0c1c8"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""00782756-16dd-46fe-aae5-a0739aafae1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Button"",
                    ""id"": ""4c4cb422-6623-4672-b35a-8a6553e58236"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""0636a3ea-3204-44e3-87c5-5a18fb123fac"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d54f90a1-9ccb-40bc-a190-e91d949979ba"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""77c9fe07-dcbe-4ab4-87b9-c949274d308b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""1c390529-e10b-45ab-b216-725673591077"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4b6ea4ee-b751-45d7-8ee1-b2c61ef4f0b6"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a0a8a281-2236-49c5-a182-878bb621ca1f"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Trigger"",
            ""id"": ""496de5e4-f1b7-49af-9f7f-baf2c5af1149"",
            ""actions"": [
                {
                    ""name"": ""ShootFireWorks"",
                    ""type"": ""Button"",
                    ""id"": ""48012a7a-5220-4c12-a1c5-6a71998b0484"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ac96e330-b04d-453b-8040-43535b7c1556"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShootFireWorks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Vertical = m_Move.FindAction("Vertical", throwIfNotFound: true);
        m_Move_Horizontal = m_Move.FindAction("Horizontal", throwIfNotFound: true);
        // Cam
        m_Cam = asset.FindActionMap("Cam", throwIfNotFound: true);
        m_Cam_Horizontal = m_Cam.FindAction("Horizontal", throwIfNotFound: true);
        m_Cam_Vertical = m_Cam.FindAction("Vertical", throwIfNotFound: true);
        // Trigger
        m_Trigger = asset.FindActionMap("Trigger", throwIfNotFound: true);
        m_Trigger_ShootFireWorks = m_Trigger.FindAction("ShootFireWorks", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Vertical;
    private readonly InputAction m_Move_Horizontal;
    public struct MoveActions
    {
        private @Controller m_Wrapper;
        public MoveActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_Move_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_Move_Horizontal;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnHorizontal;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // Cam
    private readonly InputActionMap m_Cam;
    private ICamActions m_CamActionsCallbackInterface;
    private readonly InputAction m_Cam_Horizontal;
    private readonly InputAction m_Cam_Vertical;
    public struct CamActions
    {
        private @Controller m_Wrapper;
        public CamActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Cam_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Cam_Vertical;
        public InputActionMap Get() { return m_Wrapper.m_Cam; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CamActions set) { return set.Get(); }
        public void SetCallbacks(ICamActions instance)
        {
            if (m_Wrapper.m_CamActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_CamActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_CamActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_CamActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_CamActionsCallbackInterface.OnVertical;
            }
            m_Wrapper.m_CamActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
            }
        }
    }
    public CamActions @Cam => new CamActions(this);

    // Trigger
    private readonly InputActionMap m_Trigger;
    private ITriggerActions m_TriggerActionsCallbackInterface;
    private readonly InputAction m_Trigger_ShootFireWorks;
    public struct TriggerActions
    {
        private @Controller m_Wrapper;
        public TriggerActions(@Controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootFireWorks => m_Wrapper.m_Trigger_ShootFireWorks;
        public InputActionMap Get() { return m_Wrapper.m_Trigger; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TriggerActions set) { return set.Get(); }
        public void SetCallbacks(ITriggerActions instance)
        {
            if (m_Wrapper.m_TriggerActionsCallbackInterface != null)
            {
                @ShootFireWorks.started -= m_Wrapper.m_TriggerActionsCallbackInterface.OnShootFireWorks;
                @ShootFireWorks.performed -= m_Wrapper.m_TriggerActionsCallbackInterface.OnShootFireWorks;
                @ShootFireWorks.canceled -= m_Wrapper.m_TriggerActionsCallbackInterface.OnShootFireWorks;
            }
            m_Wrapper.m_TriggerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShootFireWorks.started += instance.OnShootFireWorks;
                @ShootFireWorks.performed += instance.OnShootFireWorks;
                @ShootFireWorks.canceled += instance.OnShootFireWorks;
            }
        }
    }
    public TriggerActions @Trigger => new TriggerActions(this);
    public interface IMoveActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
    }
    public interface ICamActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
    }
    public interface ITriggerActions
    {
        void OnShootFireWorks(InputAction.CallbackContext context);
    }
}
