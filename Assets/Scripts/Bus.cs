using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : Vehicle
{
    [SerializeField] float currentSpeed;

    void Update()
    {
        RotateSelf();
    }

    // INHERITANCE
    public override void RotateSelf()
    {
        rotationSpeed = currentSpeed;
        base.RotateSelf();
    }

    private void OnMouseDown()
    {
        ChooseVehicle();
    }

    // POLYMORPHISM
    // INHERITANCE
    public override string StatsText()
    {
        modelOfVehicle = "Mercedes - Benz";
        yearOfVehicle = "2023";
        weightOfVehicle = "20.000 kg";
        priceOfVehicle = "$500.000";
        return base.StatsText();
    }
}
