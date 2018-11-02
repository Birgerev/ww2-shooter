﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponModel : MonoBehaviour {
    
    public GameObject barrel;

    public RuntimeAnimatorController armAnimatorController;

    public Animator animator;
    public Animator handler;

    public CharacterModel playerModel;

    private void Start()
    {
        gameObject.name = gameObject.name.Replace("(Clone)", "");
    }

    private void Update()
    {
        resetPosition();
        if (playerModel.armAnimator == null)
            Debug.LogError("No arm animator assigned to weapon model");
    }

    public void initializeAnimator()
    {
        playerModel.armAnimator.runtimeAnimatorController = armAnimatorController;
    }

    public void resetPosition()
    {
        transform.localPosition = new Vector3(0, 0, 0);
        transform.localRotation = Quaternion.identity;
        setGlobalScale();
    }

    private void setGlobalScale()
    {
        transform.localScale = Vector3.one;
        transform.localScale = new Vector3(1 / transform.lossyScale.x, 1 / transform.lossyScale.y, 1 / transform.lossyScale.z);
    }
}
