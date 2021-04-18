using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public int totalCoinCount;
    int curCoinCount;

    private void Start()
    {
        curCoinCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin" && curCoinCount <= totalCoinCount)
        {
            curCoinCount++;
            Destroy(other.gameObject);
            Debug.LogError(curCoinCount);
        }
        else
        {
            //Win condition here
            Debug.Log("You have won");
        }
    }
}
