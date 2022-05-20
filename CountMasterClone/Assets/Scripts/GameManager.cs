using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    public float startingStickmanAmount = 1;
    public float currentStickmanAmount = 2;
    public List<GameObject> stickmanList = new List<GameObject>();

    public SpawnStickman spawnStickman;


    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this;
    }

    void Start()
    {

    }
    
    void Update()
    {
        
    }
}
