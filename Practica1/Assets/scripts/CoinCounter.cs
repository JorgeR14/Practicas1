using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int currentNumberOFCoins;

    public Text coinText;

    public void getCoins(int coinsAmount)
    {
        currentNumberOFCoins += coinsAmount;
        Debug.Log("He recogido 1 moneda, tengo " + currentNumberOFCoins + " monedas");
        coinText.text = currentNumberOFCoins.ToString();

        if (coinText != null)
        {
            coinText.text = currentNumberOFCoins.ToString();
        }
        else
        {
            Debug.LogError("acuerdate de pasar el objeto en unity");
        }
    }
}