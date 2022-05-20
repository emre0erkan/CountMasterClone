//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Stickman : MonoBehaviour
//{
//    [SerializeField] SpawnStickman spawnStickman;
//    public float stickmanAmountToSpawn;
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.gameObject.tag == "Gate")
//        {
//            other.gameObject.GetComponent<BoxCollider>().enabled = false;
//            stickmanAmountToSpawn = other.gameObject.GetComponent<Gates>().SpawnAmount(GameManager.Instance.currentStickmanAmount);
//            spawnStickman.GetComponent<SpawnStickman>().stickmanAmountToSpawn = stickmanAmountToSpawn;
//            spawnStickman.GetComponent<SpawnStickman>().StickmanSpawn();
//            Debug.Log("doðacak " + stickmanAmountToSpawn);
//            Debug.Log("triggered");
//        }
//        else if (other.gameObject.tag == "Obstacle")
//        {
//            Debug.Log("obstacle triggered");
//            Destroy(gameObject);
//        }
//    }
//}
