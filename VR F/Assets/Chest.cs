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

    private void Update()
    {
        if(curCoinCount >= totalCoinCount)
        {
            //win condition
            Debug.Log("You win");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin" && curCoinCount <= totalCoinCount)
        {
            curCoinCount++;
            Destroy(other.gameObject);
            Debug.Log(curCoinCount);
        }
    }
}
