using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerParent : PlayerTrigger
{
    public Transform platform;

    private void Update()
    {
        transform.position = platform.position;
    }

    public override void OnPlayerEnter(GameObject playerobject)
    {
        playerobject.transform.parent = transform;
    }

    public override void OnplayerExit(GameObject playerobject)
    {
        playerobject.transform.parent = null;
    }
}