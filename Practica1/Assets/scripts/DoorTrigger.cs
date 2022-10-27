using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : PlayerTrigger
{
    public Animator doorAnimator;

    private bool doorIsOpen = true;

    public override void OnPlayerEnter(GameObject playerobject)
    {
        doorAnimator.SetBool("Opendoor", doorIsOpen);
    }

    public override void OnplayerExit(GameObject playerobject)
    {
        doorAnimator.SetBool("Opendoor", !doorIsOpen);
    }
}