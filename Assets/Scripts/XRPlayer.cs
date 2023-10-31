﻿using System;
using RootMotion.FinalIK;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Spherum.Player
{
    public class XRPlayer : MonoBehaviour
    {
        [Header("Avatar")] [SerializeField] private Animator _animator;
        [SerializeField] private VRIK _vrIk;
        [SerializeField] private float _scaleMlp = 1f;

        [Header("Input")] [SerializeField] private ActionBasedController _leftController;
        [SerializeField] private ActionBasedController _rightController;


        [SerializeField] private Transform _targetLeft;
        [SerializeField] private Transform _targetRight;


        private int _hashTriggerLeft;
        private int _hashTriggerRight;
        private int _hashGripLeft;
        private int _hashGripRight;

        private void Awake()
        {
            _hashTriggerLeft = Animator.StringToHash("Trigger_Left");
            _hashTriggerRight = Animator.StringToHash("Trigger_Right");
            _hashGripLeft = Animator.StringToHash("Grip_Left");
            _hashGripRight = Animator.StringToHash("Grip_Right");
        }

        private void Start()
        {
            _targetLeft.transform.position = _leftController.transform.position;
            _targetRight.transform.position = _rightController.transform.position;
            
           //  var sizeF = (_vrIk.solver.spine.headTarget.position.y - _vrIk.references.root.position.y) /
           //              (_vrIk.references.head.position.y - _vrIk.references.root.position.y);
           //  
           // _vrIk.references.root.localScale *= sizeF * _scaleMlp;
        }

        private void Update()
        {
            _animator.SetFloat(_hashGripLeft, _leftController.selectActionValue.action.ReadValue<float>());
            _animator.SetFloat(_hashGripRight, _rightController.selectActionValue.action.ReadValue<float>());
            _animator.SetFloat(_hashTriggerLeft, _leftController.activateActionValue.action.ReadValue<float>());
            _animator.SetFloat(_hashTriggerRight, _rightController.activateActionValue.action.ReadValue<float>());
        }
    }
}