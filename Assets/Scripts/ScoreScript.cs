using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Text destinationTicketText;

    private int score = 0;
    private int destinationTicketPoints = 0;

    private void Start()
    {
        UpdateScoreText();
        UpdateDestinationTicketText();
    }

    public void AddPoints(int points)
    {
        score += points;
        UpdateScoreText();
    }

    public void AddDestinationTicketPoints(int points)
    {
        destinationTicketPoints += points;
        UpdateDestinationTicketText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void UpdateDestinationTicketText()
    {
        destinationTicketText.text = "Destination Ticket Points: " + destinationTicketPoints.ToString();
    }
}
