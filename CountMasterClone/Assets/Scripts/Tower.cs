using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tower : MonoBehaviour
{
    public int towerHP;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Stickman")
        {
            towerHP--;
            Debug.Log(towerHP);
            if (towerHP == 0)
                Destroy(gameObject);
        }
    }
}
