using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ute : Vehicle
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
        modelOfVehicle = "Holden Ute - SV6";
        yearOfVehicle = "2015";
        weightOfVehicle = "2.000 kg";
        priceOfVehicle = "$25.000";
        return base.StatsText();
    }
}
