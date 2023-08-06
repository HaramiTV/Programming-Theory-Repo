using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Van : Vehicle
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
        modelOfVehicle = "Ford - Transit";
        yearOfVehicle = "2022";
        weightOfVehicle = "2.400 kg";
        priceOfVehicle = "$120.000";
        return base.StatsText();
    }
}
