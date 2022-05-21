using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Archer : MonoBehaviour
{
    [SerializeField] GameObject arrowPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ShootArrows();
            if (gameObject.transform.childCount >= 1)
                gameObject.transform.GetChild(0).DOMove(new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y - 3, other.gameObject.transform.position.z), 1.5f);
            
        }
    }

    public void ShootArrows()
    {
        GameObject arrow = Instantiate(arrowPrefab, transform.position, transform.rotation);
        arrow.transform.parent = gameObject.transform;

    }
}
