using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerControl : MonoBehaviour
{
    private Movement player;
    Vector3 forwardMove;

    public void SetPlayer(Movement movement)
    {
        player = movement;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "TowerArea")
        {
            Debug.Log("Tower area triggered");
            player.forwardMove = new Vector3(0f, 0f, 0f);
            gameObject.transform.DOMove(new Vector3(other.gameObject.transform.GetChild(0).position.x, gameObject.transform.position.y, gameObject.transform.position.z), 1f);
        }
        else if (other.gameObject.tag == "Boss")
        {
            Debug.Log("Boss area triggered");
            player.forwardMove = Vector3.zero;
            gameObject.transform.DOMove(new Vector3(other.gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z), 1f);
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
        else if (other.gameObject.tag == "Ramp")
        {
            transform.DOJump(new Vector3(transform.position.x, transform.position.y, transform.position.z + 26f), 5f, 1, 2f);
        }
        else if (other.gameObject.tag == "Arm")
        {
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            GameManager.Instance.StickmanCount();
        }
    }

}
