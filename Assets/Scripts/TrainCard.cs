using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TrainCard : MonoBehaviour
{
    public int id;
    public GameObject cardPrefab;
    public string cardDescription;
    public int count;

    public TrainCard()
    {

    }

    public TrainCard(int Id, GameObject CardPrefab, string CardDescription, int Count)
    {
        id = Id;
        cardPrefab = CardPrefab;
        cardDescription = CardDescription;
        count = Count;
    }
}