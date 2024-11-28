using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ManagerUI managerUI;

    public Character playerCharacter;
    private bool gameIsOver;

    private void Awake()
    {
        playerCharacter = GameObject.FindWithTag("Player").GetComponent<Character>();
        
    }

    private void GameOver()
    {
        managerUI.ShowGameOverUI();
    }

    public void GameIsFinished()
    {
        managerUI.ShowGameIsFinishedUI();

    }

    private void Update()
    {
        if (gameIsOver)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            managerUI.TogglePauseUI();
        }

        if(playerCharacter.CurrentState == Character.CharacterState.Dead)
        {
            gameIsOver = true;
            GameOver();
        }
    }

    public void ReturnToTheMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
