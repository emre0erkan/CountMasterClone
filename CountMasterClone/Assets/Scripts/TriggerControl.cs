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
            GameManager.Instance.currentStickmanAmount = GameManager.Instance.stickmanList.Count;
            GameManager.Instance.spawnStickman.stickmanCountText.text = GameManager.Instance.stickmanList.Count.ToString();
            Debug.Log(GameManager.Instance.stickmanList.Count);
        }
    }
}
