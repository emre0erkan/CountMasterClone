using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("obstacle triggered");
            Destroy(gameObject);
            GameManager.Instance.stickmanList.RemoveAt(GameManager.Instance.stickmanList.Count - 1);
            Debug.Log(GameManager.Instance.stickmanList.Count);
        }
    }
}
