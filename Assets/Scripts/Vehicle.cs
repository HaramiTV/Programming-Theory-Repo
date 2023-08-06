using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vehicle : MonoBehaviour
{
    protected float rotationSpeed;

    private string enter = "\n";

    private string model = "Model: ";
    protected string modelOfVehicle;

    private string year = "Year: ";
    protected string yearOfVehicle;

    private string weight = "Weight: ";
    protected string weightOfVehicle;

    private string price = "Price: ";
    protected string priceOfVehicle;

    public virtual void RotateSelf()
    {
        float speed;
        speed = rotationSpeed;
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

    public virtual void ChooseVehicle()
    {
        GameManager.Instance.SelectedVehicle = gameObject;

        CreateVehicle();

        SceneManager.LoadScene(1);
    }

    // ABSTRACTION
    private static void CreateVehicle()
    {
        int buildIndex = SceneManager.GetActiveScene().buildIndex;

        if (buildIndex == 0)
        {
            GameManager.Instance.SpawnVehicle();
        }
    }

    public virtual string StatsText()
    {
        return model + modelOfVehicle + enter +
            year + yearOfVehicle + enter +
            weight + weightOfVehicle + enter +
            price + priceOfVehicle;
    }
}
