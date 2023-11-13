using Fusion;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

namespace Spherum.Player
{
    public class NetworkXrPlayer : NetworkBehaviour
    {
        [Header("Avatar")] [SerializeField] private Animator _animator;
        [SerializeField] private VRIK _vrIk;
        [SerializeField] private float _scaleMlp = 1f;

        [Header("Input")] [SerializeField] private ActionBasedController _leftController;
        [SerializeField] private ActionBasedController _rightController;
        [SerializeField] private InputActionProperty _inputCalibarate;

        [Header("IK")] [SerializeField] private Transform _targetLeft;
        [SerializeField] private Transform _targetRight;
        [SerializeField] private Transform _targetHead;

        [Header("Xr")] [SerializeField] private GameObject _xrController;
        [SerializeField] private Transform _camera;
        [SerializeField] private Transform _playerArmature;

        [SerializeField] private float _offestZ;

        // [Networked(OnChanged = nameof(ChangeScalePlayer))]
        // public Vector3 Scale { get; set; }

        private int _hashTriggerLeft;
        private int _hashTriggerRight;
        private int _hashGripLeft;
        private int _hashGripRight;


    //     private void Awake()
    //     {
    //         _hashTriggerLeft = Animator.StringToHash("Trigger_Left");
    //         _hashTriggerRight = Animator.StringToHash("Trigger_Right");
    //         _hashGripLeft = Animator.StringToHash("Grip_Left");
    //         _hashGripRight = Animator.StringToHash("Grip_Right");
    //
    //         _targetLeft.position = _leftController.transform.position;
    //         _targetRight.position = _rightController.transform.position;
    //     }
    //
    //     private static void ChangeScalePlayer(Changed<NetworkXrPlayer> network)
    //     {
    //         network.Behaviour.transform.localScale = network.Behaviour.Scale;
    //     }
    //
    //     public override void FixedUpdateNetwork()
    //     {
    //         if (!HasStateAuthority)
    //         {
    //             return;
    //         }
    //
    //         if (_inputCalibarate.action.WasPressedThisFrame())
    //         {
    //             var sizeF = (_vrIk.solver.spine.headTarget.position.y - _vrIk.references.root.position.y) /
    //                         (_vrIk.references.head.position.y - _vrIk.references.root.position.y);
    //
    //             Scale = _vrIk.references.root.localScale * sizeF * _scaleMlp;
    //         }
    //
    //
    //         _targetHead.position = _camera.TransformPoint(new Vector3(0, 0, -0.15f));
    //         _targetHead.rotation = _camera.rotation * Quaternion.Euler(0, -90, 0);
    //
    //         _targetLeft.position = _leftController.transform.TransformPoint(Vector3.zero);
    //         _targetLeft.rotation = _leftController.transform.rotation * Quaternion.Euler(-90, 180, 0);
    //
    //         _targetRight.position = _rightController.transform.TransformPoint(Vector3.zero);
    //         _targetRight.rotation = _rightController.transform.rotation * Quaternion.Euler(new Vector3(90, 180, 0));
    //
    //         _xrController.SetActive(true);
    //
    //         _animator.SetFloat(_hashGripLeft, _leftController.selectActionValue.action.ReadValue<float>());
    //         _animator.SetFloat(_hashGripRight, _rightController.selectActionValue.action.ReadValue<float>());
    //         _animator.SetFloat(_hashTriggerLeft, _leftController.activateActionValue.action.ReadValue<float>());
    //         _animator.SetFloat(_hashTriggerRight, _rightController.activateActionValue.action.ReadValue<float>());
    //     }
    }
}