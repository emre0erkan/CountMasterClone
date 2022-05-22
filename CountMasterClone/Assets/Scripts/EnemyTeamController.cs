using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class EnemyTeamController : MonoBehaviour
{
    private float radiusFactor = 0.4f;
    private float angleFactor = 0.627f;

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float enemyCount;
    [SerializeField] Text enemyCountText;
    [SerializeField] private float baseAngle = 90;

    private List<GameObject> enemyList = new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            SpawnEnemy();
        }
        EnemyArrenger();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Stickman")
    //    {
    //            gameObject.transform.GetChild(3).transform.DOMove(new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y,
    //                other.gameObject.transform.position.z), 0.4f);

    //    }
    //}

    public void SpawnEnemy()
    {

        GameObject enemy = Instantiate(enemyPrefab);
        enemyList.Add(enemy);
        enemy.transform.parent = gameObject.transform;
        enemy.transform.localPosition = Vector3.zero;
        enemy.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        enemyCountText.text = enemyCount.ToString();
    }

    private void EnemyArrenger()
    {
        // float goldenAngle = 137.5f * angleFactor;

        float baseAngleRad = Mathf.Deg2Rad * baseAngle;

        for (int i = 0; i < transform.childCount; i++)
        {
            float x = radiusFactor * Mathf.Sqrt(i + 1) * Mathf.Cos(angleFactor * baseAngleRad * (i + 1));
            float z = radiusFactor * Mathf.Sqrt(i + 1) * Mathf.Sin(angleFactor * baseAngleRad * (i + 1));

            Vector3 runnerLocalPosition = new Vector3(x, transform.GetChild(i).localPosition.y, z);
            //transform.GetChild(i).localPosition = Vector3.Lerp(transform.GetChild(i).localPosition, runnerLocalPosition, 0.1f);
            transform.GetChild(i).DOLocalMove(runnerLocalPosition, 0.2f);

        }

    }
}
