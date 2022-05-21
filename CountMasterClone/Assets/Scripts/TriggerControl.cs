using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerControl : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TowerArea")
        {
            Debug.Log("Tower area triggered");
            gameObject.transform.DOMove(new Vector3(other.gameObject.transform.GetChild(0).position.x, 1, other.gameObject.transform.GetChild(0).position.z), 1f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            GameManager.Instance.StickmanCount();
        }
        else if (other.gameObject.tag == "EnemyStickman")
        {
            Debug.Log("Enemy triggered");
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameManager.Instance.StickmanCount();

        }
        else if (other.gameObject.tag == "Arrow")
        {
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameManager.Instance.StickmanCount();
        }

        else if (other.gameObject.tag == "Tower")
        {
            Debug.Log("Tower triggered");
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            GameManager.Instance.StickmanCount();
        }
    }

}
