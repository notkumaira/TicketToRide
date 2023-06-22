using UnityEngine;

public class TrainCarSpawner : MonoBehaviour
{
    public GameObject trainCarPrefab;
    public int numberOfCars = 45;

    private string chosenColor;
    private bool hasChosenColor = false;

    public void SetChosenColor(string color)
    {
        chosenColor = color;
        hasChosenColor = true;
    }

    private void Update()
    {
        if (hasChosenColor)
        {
            SpawnTrainCars();
            hasChosenColor = false;
        }
    }

    private void SpawnTrainCars()
    {
        for (int i = 0; i < numberOfCars; i++)
        {
            GameObject trainCar = Instantiate(trainCarPrefab, transform.position + new Vector3(i * 1.5f, 0f, 0f), Quaternion.identity);
            trainCar.GetComponent<SpriteRenderer>().color = GetColorFromName(chosenColor);
        }
    }

    private Color GetColorFromName(string colorName)
    {
        Color color = Color.white;

        switch (colorName)
        {
            case "Red":
                color = Color.red;
                break;
            case "Yellow":
                color = Color.yellow;
                break;
            case "Green":
                color = Color.green;
                break;
            case "Blue":
                color = Color.blue;
                break;
        }

        return color;
    }
}
// Assign the train car prefab to the trainCarPrefab variable in the Inspector. 