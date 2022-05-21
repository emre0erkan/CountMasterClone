using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SpawnStickman : MonoBehaviour
{

    [Range(0f, 1f)]
    [SerializeField] private float radiusFactor;
    [Range(0f, 1f)]
    [SerializeField] private float angleFactor;

    [SerializeField] GameObject Stickman;
    Gates gates;

    public float stickmanAmountToSpawn;
    public Text stickmanCountText;
    [SerializeField] private float baseAngle = 90;

    

    private void Start()
    {
        for (int i = 0; i < GameManager.Instance.startingStickmanAmount; i++)
        {
            Spawn();
        }
        
    }

    public void StickmanSpawn()
    {
        for (int i = 0; i < stickmanAmountToSpawn; i++)
        {
            Spawn();
            Debug.Log("kaç kere" + stickmanAmountToSpawn);
        }
        StickmanArranger();
    }

    public void Spawn()
    {
        GameObject stickman = Instantiate(Stickman);
        GameManager.Instance.stickmanList.Add(stickman);
        GameManager.Instance.currentStickmanAmount = GameManager.Instance.stickmanList.Count;
        stickman.transform.parent = gameObject.transform;
        stickman.transform.localPosition = new Vector3(Random.Range(-3f, 3f), 1, Random.Range(-4f, 4));
        stickman.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        stickmanCountText.text = GameManager.Instance.currentStickmanAmount.ToString();
        
    }

    private void StickmanArranger()
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
