using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    [SerializeField] Movement movement;
    [SerializeField] GameObject startMenu;
    [SerializeField] GameObject gameOver;
    [SerializeField] GameObject winScreen;

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

    private void Update()
    {
        if (stickmanList.Count == 0)
            GameOver();
    }
    private void OnEnable()
    {
        
        instance = this;
    }

    public void StartGame()
    {
        startMenu.SetActive(false);
        movement.GetComponent<Movement>().forwardMove = new Vector3(0f, 0f, 0.2f);
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StickmanCount()
    {
        currentStickmanAmount = stickmanList.Count;
        spawnStickman.stickmanCountText.text = stickmanList.Count.ToString();
    }

    public void LoadNextScene()
    {
        startMenu.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameOver()
    {
        movement.GetComponent<Movement>().forwardMove = Vector3.zero;
        gameOver.SetActive(true);
    }

    public void Win()
    {
        winScreen.SetActive(true);
    }
}
