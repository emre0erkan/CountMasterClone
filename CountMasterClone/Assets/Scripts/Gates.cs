using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class Gates : MonoBehaviour
{
    [SerializeField] Operation operationType;
    [SerializeField] float value;
    [SerializeField] TextMeshProUGUI gateText;
    public float stickmanAmountToSpawn;

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

    private void Start()
    {
        switch (operationType)
        {
            case Operation.addition:
                gateText.text = "+" + value;
                break;
            case Operation.multiplication:
                gateText.text = "x" + value;
                break;
        }
    }

    public enum Operation
    {
        addition,
        multiplication,
    }
}
