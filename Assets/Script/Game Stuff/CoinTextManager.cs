using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinTextManager : MonoBehaviour
{
    public Invetory playerInvetory;
    public TextMeshProUGUI coinDisplay;

    public void UpdateCoinCount()
    {
        coinDisplay.text = "" + playerInvetory.coins;
    }
}
