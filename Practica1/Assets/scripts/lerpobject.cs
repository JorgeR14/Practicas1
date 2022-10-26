using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpobject : MonoBehaviour
{
    public Transform objectToMove;
    public Transform initialPos, finalPos;

    public float timeToLerp = 5;
    private float elapsedTime = 0;

    private AnimationCurve currentCurve;

    public AnimationCurve initialCurve, finalCurve;

    // Update is called once per frame

    private void Start()
    {
        currentCurve = initialCurve;
    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        float LerpPercentage = elapsedTime / timeToLerp;

        objectToMove.position = Vector3.Lerp(initialPos.position, finalPos.position, currentCurve.Evaluate(LerpPercentage));

        if (elapsedTime > timeToLerp)
        {
            elapsedTime = 0;
            Swap();
            ChangeCurve();
        }
    }

    public void Swap()
    {
        Transform temp = initialPos;
        initialPos = finalPos;
        finalPos = temp;
    }

    public void ChangeCurve()
    {
        if (currentCurve == initialCurve)
        {
            currentCurve = finalCurve;
        }
        else
        {
            currentCurve = initialCurve;
        }
    }
}