using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
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
        modelOfVehicle = "Vecihi - K-VI";
        yearOfVehicle = "1925";
        weightOfVehicle = "650 kg";
        priceOfVehicle = "$5.000.000";
        return base.StatsText();
    }
}