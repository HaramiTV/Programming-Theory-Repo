using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI statsText;
    [SerializeField] TextMeshProUGUI typeText;
    Vehicle vehicle;

    private void Update()
    {
        vehicle = FindObjectOfType<Vehicle>().GetComponent<Vehicle>();

        //POLYMORPHISM
        statsText.text = vehicle.StatsText();
        typeText.text = vehicle.GetType().ToString();
    }
}
