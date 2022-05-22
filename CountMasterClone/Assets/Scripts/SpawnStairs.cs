using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStairs : MonoBehaviour
{
    [SerializeField] GameObject stepPrefab;
    [SerializeField] int stepCount = 0;
    private Vector3 stepPosition = new Vector3(0f, 0f, 420f);

    void Start()
    {
        Debug.Log("step count " + stepCount);
        SpawnSteps();
    }

    private void SpawnSteps()
    {

        //for (int i = 0; i < stepCount; i++)
        //{
        //    float stepX = 0, stepY = 0, stepZ = 0;
        //    stepPosition = new Vector3(stepX, stepY + 2f, stepZ + 3f);
        //    GameObject step = Instantiate(stepPrefab);
        //    step.transform.parent = gameObject.transform;
        //    step.transform.position = stepPosition;
        //    step.transform.localPosition = Vector3.zero;
        //    step.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        //}

        do
        {
            stepCount++;
            Debug.Log("step position " + stepPosition.y);
            Debug.Log("step count " + stepCount);
            GameObject step = Instantiate(stepPrefab);
            step.transform.parent = gameObject.transform;
            step.transform.position = stepPosition;
            step.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            stepPosition.y += 2.2f;
            stepPosition.z += 3f;

        } while (stepCount <= 25);

    }
}
