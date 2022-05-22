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
        SpawnSteps();
    }

    private void SpawnSteps()
    {
        do
        {
            stepCount++;
            GameObject step = Instantiate(stepPrefab);
            step.transform.parent = gameObject.transform;
            step.transform.position = stepPosition;
            step.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            stepPosition.y += 2.2f;
            stepPosition.z += 3f;

        } while (stepCount <= 25);

    }
}
