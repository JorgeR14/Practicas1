using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : PlayerTrigger
{
    public override void OnPlayerEnter(GameObject playerobject)
    {
        LevelManager levelmanager = GetComponent<LevelManager>();
        levelmanager.NextLevel();
    }
}