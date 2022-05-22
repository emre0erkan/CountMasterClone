using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Tower : MonoBehaviour
{
    public int towerHP;
    [SerializeField] Text towerText;

    private void Start()
    {
        towerText.text = towerHP.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stickman")
        {
            towerHP--;
            towerText.text = towerHP.ToString();
            if (towerHP == 1) 
            { 
                Destroy(gameObject);
            }
        }
    }
}
