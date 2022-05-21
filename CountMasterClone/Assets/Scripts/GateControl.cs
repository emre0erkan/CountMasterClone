using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateControl : MonoBehaviour
{
    public float stickmanAmountToSpawn;
    public bool passedGateOnce = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gate")
        {
            if (!passedGateOnce)
            {
                other.gameObject.GetComponent<BoxCollider>().enabled = false;
                stickmanAmountToSpawn = other.gameObject.GetComponent<Gates>().SpawnAmount(GameManager.Instance.currentStickmanAmount);
                gameObject.GetComponent<SpawnStickman>().stickmanAmountToSpawn = stickmanAmountToSpawn;
                gameObject.GetComponent<SpawnStickman>().StickmanSpawn();
                passedGateOnce = true;
                StartCoroutine(ActivateGate());
            }

        }

        IEnumerator ActivateGate()
        {
            yield return new WaitForSeconds(1.5f);
            passedGateOnce = false;
        }
    }
}
