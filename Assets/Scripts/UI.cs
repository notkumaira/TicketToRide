using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject winScreen;
    public GameObject loseScreen;

    public Button startButton;
    public Button exitButton;
    public Button quitButton;
    public Button resumeButton;
    public Button winExitButton;
    public Button loseExitButton;

    private bool isGamePaused = false;
    private bool isGameStarted = false;
    private bool isGameWon = false;
    private bool isGameLost = false;

    private void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
        quitButton.onClick.AddListener(QuitGame);
        resumeButton.onClick.AddListener(ResumeGame);
        winExitButton.onClick.AddListener(ExitGame);
        loseExitButton.onClick.AddListener(ExitGame);

        HidePauseMenu();
        HideWinScreen();
        HideLoseScreen();

        ShowStartMenu();
    }

    private void StartGame()
    {
        isGameStarted = true;
        HideStartMenu();
        // Start the game logic
    }

    private void ExitGame()
    {
        // Clean up and exit the application
        Application.Quit();
    }

    private void QuitGame()
    {
        PauseGame();
        ShowPauseMenu();
    }

    private void ResumeGame()
    {
        HidePauseMenu();
        ResumeGameLogic();
    }

    private void PauseGame()
    {
        isGamePaused = true;
        // Pause the game logic
    }

    private void ResumeGameLogic()
    {
        isGamePaused = false;
        // Resume the game logic
    }

    private void ShowStartMenu()
    {
        startMenu.SetActive(true);
    }

    private void HideStartMenu()
    {
        startMenu.SetActive(false);
    }

    private void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
    }

    private void HidePauseMenu()
    {
        pauseMenu.SetActive(false);
    }

    private void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }

    private void HideWinScreen()
    {
        winScreen.SetActive(false);
    }

    private void ShowLoseScreen()
    {
        loseScreen.SetActive(true);
    }

    private void HideLoseScreen()
    {
        loseScreen.SetActive(false);
    }

    private void Update()
    {
        if (isGameStarted && !isGamePaused)
        {
            // Update game logic
            if (isGameWon)
            {
                PauseGame();
                ShowWinScreen();
            }
            else if (isGameLost)
            {
                PauseGame();
                ShowLoseScreen();
            }
        }
    }
}
