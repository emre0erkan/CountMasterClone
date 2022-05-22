using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerParent;
    [SerializeField] Transform target;
    [SerializeField] float speed = 1f;

    //Vector3 followPos;
    private bool isEnding = false;

    private void Start()
    {
        //followPos = new Vector3(0, playerParent.position.y + 21f, playerParent.position.z - 7);
    }
    void Update()
    {
        if (!isEnding)
            transform.position = new Vector3(0, playerParent.position.y + 21f, playerParent.position.z - 7);
        else
        {
            transform.DOMove(new Vector3(playerParent.position.x + 10f, playerParent.position.y + 8f, playerParent.position.z - 10f), 2f);
            //transform.position = new Vector3(playerParent.position.x + 10f, playerParent.position.y + 8f, playerParent.position.z - 10f);
            transform.DORotate(new Vector3(0f, -40f, 0f), 2f).SetEase(Ease.Linear);
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BonusGate")
        {
            isEnding = true;
        }
    }

    //public void ChangeCameraPosition()
    //{
    //    followPos = new Vector3(playerParent.position.x + 10f, playerParent.position.y + 15f, playerParent.position.z - 10f);
    //}
}
