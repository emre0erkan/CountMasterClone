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
            if (towerHP == 1) 
            { 
                gameObject.GetComponent<CapsuleCollider>().enabled = false;
                Destroy(gameObject);
            }
        }
    }
}
