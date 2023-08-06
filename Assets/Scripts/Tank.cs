using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
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
        modelOfVehicle = "Panzer IV - Ausf.F";
        yearOfVehicle = "1941";
        weightOfVehicle = "25.000 kg";
        priceOfVehicle = "$2.400.000";
        return base.StatsText();
    }
}