using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    [SerializeField] Movement movement;
    [SerializeField] GameObject startMenu;

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

    private void Update()
    {
        StickmanCount();
    }
    public void StartGame()
    {
        startMenu.SetActive(false);
        movement.GetComponent<Movement>().forwardMove = new Vector3(0f, 0f, 0.2f);
    }

    public void StickmanCount()
    {
        currentStickmanAmount = stickmanList.Count;
        spawnStickman.stickmanCountText.text = stickmanList.Count.ToString();
    }
}
