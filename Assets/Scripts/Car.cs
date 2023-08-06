using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
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
        modelOfVehicle = "Fiat - Tempra";
        yearOfVehicle = "1993";
        weightOfVehicle = "1.125 kg";
        priceOfVehicle = "$5.400";
        return base.StatsText();
    }
}