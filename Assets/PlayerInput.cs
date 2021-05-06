// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""04145a80-e0d5-4c3b-8c31-9d67f889858a"",
            ""actions"": [
                {
                    ""name"": ""LStick"",
                    ""type"": ""Value"",
                    ""id"": ""b8633fc1-5b93-4a8c-8aaf-dea02b4a8f76"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RStick"",
                    ""type"": ""Value"",
                    ""id"": ""12c37166-38ad-48a1-ad7e-c2b10793165b"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""8be0b821-a20c-4ac5-99d8-73880781d69d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""5ee2f70e-7f65-4c9f-9d5f-c8dcbb0b10a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X"",
                    ""type"": ""Button"",
                    ""id"": ""43d9ae41-ff1a-4851-9edb-90a705243790"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""746b1846-2139-40be-9a20-c4a65c8bd729"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LB"",
                    ""type"": ""Button"",
                    ""id"": ""dceb9374-fbb4-4ad4-9302-8ed70c1e7758"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LT"",
                    ""type"": ""Button"",
                    ""id"": ""ef36ee91-adbc-41c0-9e6a-ee496265794d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""41bcba45-f899-4b28-8026-3c5245b7b882"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RT"",
                    ""type"": ""Button"",
                    ""id"": ""d61b19ae-c93e-4787-91f8-0e22afef15fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPad"",
                    ""type"": ""Value"",
                    ""id"": ""8d376720-a92b-4a6c-9961-86ccdc18018f"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""95eddb67-fe72-4f22-9065-bde88c191d88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""b8b9fc52-8d15-45f7-9460-3cea7b96161b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a20f08e-b942-4e30-85be-5b6fd3e22c60"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a10e88e-77a9-4ebb-b58d-1ac2da7f69da"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""419fbf52-b326-456f-b1d4-d16ad397f7f8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LStick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""732d503c-a04d-49dc-871b-b69f16567e79"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""114da1a1-8aae-49a1-88fb-c94ff9b4a272"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7793992-b444-44d3-93c5-b2b5532bda04"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""959c3417-b690-4f7d-ae0c-ae08c197f72d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f7660dc-227d-48f1-8f56-088d55785770"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0eef8d0e-50dd-433c-bbf9-bff2341b7764"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8892c23-9276-4617-81d0-30ffd51ed440"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d29883-aa01-4759-80a2-48e8f19e4297"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d024c0bd-99cd-4e23-ac37-f74ac29a4668"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0730ced-963e-46b3-aec8-0f4357e0303a"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LStick = m_Player.FindAction("LStick", throwIfNotFound: true);
        m_Player_RStick = m_Player.FindAction("RStick", throwIfNotFound: true);
        m_Player_A = m_Player.FindAction("A", throwIfNotFound: true);
        m_Player_B = m_Player.FindAction("B", throwIfNotFound: true);
        m_Player_X = m_Player.FindAction("X", throwIfNotFound: true);
        m_Player_Y = m_Player.FindAction("Y", throwIfNotFound: true);
        m_Player_LB = m_Player.FindAction("LB", throwIfNotFound: true);
        m_Player_LT = m_Player.FindAction("LT", throwIfNotFound: true);
        m_Player_RB = m_Player.FindAction("RB", throwIfNotFound: true);
        m_Player_RT = m_Player.FindAction("RT", throwIfNotFound: true);
        m_Player_DPad = m_Player.FindAction("DPad", throwIfNotFound: true);
        m_Player_Start = m_Player.FindAction("Start", throwIfNotFound: true);
        m_Player_Select = m_Player.FindAction("Select", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LStick;
    private readonly InputAction m_Player_RStick;
    private readonly InputAction m_Player_A;
    private readonly InputAction m_Player_B;
    private readonly InputAction m_Player_X;
    private readonly InputAction m_Player_Y;
    private readonly InputAction m_Player_LB;
    private readonly InputAction m_Player_LT;
    private readonly InputAction m_Player_RB;
    private readonly InputAction m_Player_RT;
    private readonly InputAction m_Player_DPad;
    private readonly InputAction m_Player_Start;
    private readonly InputAction m_Player_Select;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LStick => m_Wrapper.m_Player_LStick;
        public InputAction @RStick => m_Wrapper.m_Player_RStick;
        public InputAction @A => m_Wrapper.m_Player_A;
        public InputAction @B => m_Wrapper.m_Player_B;
        public InputAction @X => m_Wrapper.m_Player_X;
        public InputAction @Y => m_Wrapper.m_Player_Y;
        public InputAction @LB => m_Wrapper.m_Player_LB;
        public InputAction @LT => m_Wrapper.m_Player_LT;
        public InputAction @RB => m_Wrapper.m_Player_RB;
        public InputAction @RT => m_Wrapper.m_Player_RT;
        public InputAction @DPad => m_Wrapper.m_Player_DPad;
        public InputAction @Start => m_Wrapper.m_Player_Start;
        public InputAction @Select => m_Wrapper.m_Player_Select;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LStick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLStick;
                @LStick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLStick;
                @LStick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLStick;
                @RStick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRStick;
                @RStick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRStick;
                @RStick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRStick;
                @A.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @X.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @X.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnX;
                @Y.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @LB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLB;
                @LB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLB;
                @LB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLB;
                @LT.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLT;
                @LT.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLT;
                @LT.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLT;
                @RB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRB;
                @RT.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRT;
                @RT.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRT;
                @RT.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRT;
                @DPad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPad;
                @DPad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPad;
                @DPad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPad;
                @Start.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LStick.started += instance.OnLStick;
                @LStick.performed += instance.OnLStick;
                @LStick.canceled += instance.OnLStick;
                @RStick.started += instance.OnRStick;
                @RStick.performed += instance.OnRStick;
                @RStick.canceled += instance.OnRStick;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @X.started += instance.OnX;
                @X.performed += instance.OnX;
                @X.canceled += instance.OnX;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @LB.started += instance.OnLB;
                @LB.performed += instance.OnLB;
                @LB.canceled += instance.OnLB;
                @LT.started += instance.OnLT;
                @LT.performed += instance.OnLT;
                @LT.canceled += instance.OnLT;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @RT.started += instance.OnRT;
                @RT.performed += instance.OnRT;
                @RT.canceled += instance.OnRT;
                @DPad.started += instance.OnDPad;
                @DPad.performed += instance.OnDPad;
                @DPad.canceled += instance.OnDPad;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnLStick(InputAction.CallbackContext context);
        void OnRStick(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnX(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnLB(InputAction.CallbackContext context);
        void OnLT(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnRT(InputAction.CallbackContext context);
        void OnDPad(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
