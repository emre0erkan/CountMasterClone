using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerParent;
    void Update()
    {
        transform.position = new Vector3(0, playerParent.position.y + 15f, playerParent.position.z - 18);
    }
}