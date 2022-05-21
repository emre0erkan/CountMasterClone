using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            //GameManager.Instance.StickmanCount();
        }
        else if (other.gameObject.tag == "EnemyStickman")
        {
            Debug.Log("Enemy triggered");
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            Destroy(other.gameObject);
            //GameManager.Instance.StickmanCount();

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
            other.gameObject.GetComponent<Tower>().towerHP--;
            Debug.Log("tower hp " + other.gameObject.GetComponent<Tower>().towerHP);
            GameManager.Instance.StickmanCount();
        }
    }

}
