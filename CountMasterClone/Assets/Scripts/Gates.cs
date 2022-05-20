using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Gates : MonoBehaviour
{
    [SerializeField] Operation operationType;
    [SerializeField] float value;
    [SerializeField] Text gateText;
    public float stickmanAmountToSpawn;

    private void Start()
    {
        
    }
    public float SpawnAmount(float stickmanAmount)
    {
        if (operationType == Operation.addition)
        {
            return value;
        }
        else if (operationType == Operation.multiplication)
        {
            return stickmanAmount * value;
        }
        return -1;
    }

    //private void Start()
    //{
    //    switch (operationType)
    //    {
    //        case Operation.addition:
    //            gateText.text = "+" + value;
    //            break;
    //        case Operation.multiplication:
    //            gateText.text = "x" + value;
    //            break;
    //    }
    //}

    //public float Calculate(float moneyAmount)
    //{

    //}

    public enum Operation
    {
        addition,
        multiplication,
    }
}
