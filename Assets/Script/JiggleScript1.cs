using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JiggleScript : MonoBehaviour
{
    [Range(0, 1)]
    public float power = 0.1f;

    [Header("Position Jiggle effect")]
    public Boolean jigPos = true;
    public Vector3 positionJigAmount;
    [Range(0, 120)]
    public float positionFrequency = 10;
    float positionTime;
    Vector3 basePosition;


    [Header("Rotation Jiggle effect")]
    public Boolean jigRot = true;
    public Vector3 rotationJigAmount;
    [Range(0, 120)]
    public float rotationFrequency = 10;
    float rotationTime;
    Quaternion baseRotation;

    [Header("Scale Jiggle effect")]
    public Boolean jigScale = true;
    public Vector3 scaleJigAmount = new Vector3(0.1f, -0.1f, 0.1f);
    [Range(0, 120)]
    public float scaleFrequency = 10;
    float scaleTime;
    Vector3 baseScale;

    private void Start()
    {
        basePosition = transform.localPosition;
        baseRotation = transform.localRotation;
        baseScale = transform.localScale;
    }

    private void Update()
    {
        var dt = Time.deltaTime;
        positionTime += dt * positionFrequency;

        if (jigPos)
            transform.localPosition = basePosition + positionJigAmount * Mathf.Sin(positionTime) * power;

        rotationTime += dt * rotationFrequency;

        if (jigRot)
            transform.localRotation = baseRotation * Quaternion.Euler(rotationJigAmount * Mathf.Sin(rotationTime) * power);

        scaleTime += dt * scaleFrequency;
        if(jigScale)
            transform.localScale = baseScale + scaleJigAmount * Mathf.Sin(scaleTime) * power;
    }
}