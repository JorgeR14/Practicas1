using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : PlayerTrigger
{
    public int amountToGive = 1;

    public override void OnPlayerEnter(GameObject playerobject)
    {
        CoinCounter counter = playerobject.GetComponent<CoinCounter>();
        counter.getCoins(amountToGive);
        gameObject.SetActive(false);
    }
}