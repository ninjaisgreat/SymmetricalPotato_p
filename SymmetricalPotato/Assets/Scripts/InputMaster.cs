// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class InputMaster : IInputActionCollection
{
    private InputActionAsset asset;
    public InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player0"",
            ""id"": ""dc90914e-35ed-4817-983d-d6843e50457d"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""6eff4f9a-ee46-49de-ba4c-2a16a384f84e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Button"",
                    ""id"": ""6118ed5a-682b-4fd3-8514-3706cb74cddc"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""9eacbd39-b665-4350-a480-9e3b3c1082ff"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""79c8f15b-3ca2-4d61-b271-c9e39eca35bb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9384f4c3-6e0f-4c9d-8f5c-4bb3c24811f9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""7853435f-5aca-4317-a40b-ed3ad97a8324"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""098f4ef7-f6c0-467e-88da-3f7f93d60585"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2d1a4f7d-3d4f-42d7-a91b-aedfbdcc55b9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player0
        m_Player0 = asset.FindActionMap("Player0", throwIfNotFound: true);
        m_Player0_MoveX = m_Player0.FindAction("MoveX", throwIfNotFound: true);
        m_Player0_MoveY = m_Player0.FindAction("MoveY", throwIfNotFound: true);
    }

    ~InputMaster()
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

    // Player0
    private readonly InputActionMap m_Player0;
    private IPlayer0Actions m_Player0ActionsCallbackInterface;
    private readonly InputAction m_Player0_MoveX;
    private readonly InputAction m_Player0_MoveY;
    public struct Player0Actions
    {
        private InputMaster m_Wrapper;
        public Player0Actions(InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Player0_MoveX;
        public InputAction @MoveY => m_Wrapper.m_Player0_MoveY;
        public InputActionMap Get() { return m_Wrapper.m_Player0; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player0Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer0Actions instance)
        {
            if (m_Wrapper.m_Player0ActionsCallbackInterface != null)
            {
                MoveX.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveX;
                MoveX.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveX;
                MoveX.canceled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveX;
                MoveY.started -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveY;
                MoveY.performed -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveY;
                MoveY.canceled -= m_Wrapper.m_Player0ActionsCallbackInterface.OnMoveY;
            }
            m_Wrapper.m_Player0ActionsCallbackInterface = instance;
            if (instance != null)
            {
                MoveX.started += instance.OnMoveX;
                MoveX.performed += instance.OnMoveX;
                MoveX.canceled += instance.OnMoveX;
                MoveY.started += instance.OnMoveY;
                MoveY.performed += instance.OnMoveY;
                MoveY.canceled += instance.OnMoveY;
            }
        }
    }
    public Player0Actions @Player0 => new Player0Actions(this);
    public interface IPlayer0Actions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
    }
}
