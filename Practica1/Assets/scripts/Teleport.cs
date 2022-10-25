using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : PlayerTrigger
{
    public Transform targetPosition;

    public override void OnPlayerEnter(GameObject playerobject)
    {
        playerobject.transform.position = targetPosition.position;
    }
}