using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TriggerControl : MonoBehaviour
{
    private Movement player;
    [SerializeField] Camera cam;
    Vector3 forwardMove;

    public void SetPlayer(Movement movement)
    {
        player = movement;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "TowerArea")
        {
            Debug.Log("Tower area triggered");
            player.forwardMove = new Vector3(0f, 0f, 0.05f);
            gameObject.transform.DOMove(new Vector3(other.gameObject.transform.GetChild(0).position.x, gameObject.transform.position.y,
                other.gameObject.transform.GetChild(0).position.z), 0.7f).OnComplete(() =>
            {
                Debug.Log("Tower triggered");
                GameManager.Instance.stickmanList.Remove(gameObject);
                Destroy(gameObject);
                GameManager.Instance.StickmanCount();
            });
            if (other.gameObject.GetComponent<Tower>().towerHP <= 1)
                player.forwardMove = new Vector3(0f, 0f, 0.2f);
        }
        else if (other.gameObject.tag == "Boss")
        {
            Debug.Log("Boss area triggered");
            player.forwardMove = new Vector3(0f, 0f, 0.05f);
            gameObject.transform.DOMove(new Vector3(other.gameObject.transform.GetChild(0).position.x, gameObject.transform.position.y,
                other.gameObject.transform.GetChild(0).position.z), 0.7f).OnComplete(() =>
                {
                    GameManager.Instance.stickmanList.Remove(gameObject);
                    Destroy(gameObject);
                    GameManager.Instance.StickmanCount();
                });
        }
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
        else if (other.gameObject.tag == "Ramp")
        {
            //transform.DOJump(new Vector3(transform.position.x, transform.position.y, transform.position.z + 30f), 6f, 1, 1.5f);
            if (player.forwardMove == new Vector3(0f, 0f, 0.2f))
                player.forwardMove = new Vector3(0f, 0f, 0.3f);
            transform.DOLocalMoveY(8f, 0.8f).OnComplete(() =>
            {
                transform.DOLocalMoveY(1f, 0.8f).OnComplete(() =>
                {
                    if (player.forwardMove == new Vector3(0f, 0f, 0.3f))
                        player.forwardMove = new Vector3(0f, 0f, 0.2f);
                });
            });
        }
        else if (other.gameObject.tag == "EnemyTeam")
        {
            Debug.Log("EnemyTeam triggered");
            player.forwardMove = new Vector3(0f, 0f, 0.05f);
            //gameObject.transform.DOMove(new Vector3(other.gameObject.transform.position.x, gameObject.transform.position.y, other.gameObject.transform.GetChild(3).position.z), 1f);
        }
        else if (other.gameObject.tag == "Arm")
        {
            Debug.Log("Arm triggered");
            GameManager.Instance.stickmanList.Remove(gameObject);
            Destroy(gameObject);
            GameManager.Instance.StickmanCount();
        }
        else if (other.gameObject.tag == "Finish")
        {
            GameManager.Instance.LoadNextScene();
        }
        else if (other.gameObject.tag == "BehindBoss")
        {
            player.forwardMove = Vector3.zero;
        }
        //else if (other.gameObject.tag == "BonusGate")
        //{
        //    player.forwardMove = Vector3.zero;
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "TowerArea")
        {
            player.forwardMove = new Vector3(0f, 0f, 0.2f);
        }
        else if (other.gameObject.tag == "EnemyTeam")
        {
            player.forwardMove = new Vector3(0f, 0f, 0.2f);
        }
        //else if (other.gameObject.tag == "Boss")
        //{
        //    player.forwardMove = new Vector3(0f, 0f, 0f);
        //    if (other.gameObject.GetComponent<Boss>().bossHP == 0)
        //    {
        //        Debug.Log("Boss öldü");
        //        player.forwardMove = new Vector3(0f, 0f, 0f);
        //    }
                
        //}
    }
}
