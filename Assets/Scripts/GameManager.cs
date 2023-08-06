using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] GameObject selectedVehicle;

    private void Awake()
    {
        if (Instance)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        HideDuplicateVehicles();
    }


    // ABSTRACTION
    private void HideDuplicateVehicles()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            return;
        }
        else if (currentSceneIndex == 1)
        {
            selectedVehicle.gameObject.SetActive(true);
        }
    }

    //ENCAPSULATION
    public GameObject SelectedVehicle
    {
        get
        {
            return selectedVehicle;
        }

        set
        {
            selectedVehicle = value;
        }
    }

    // ABSTRACTION
    public void SpawnVehicle()
    {
        Vector3 position = new Vector3(-2.5f, 1f, 8.75f);
        selectedVehicle = Instantiate(selectedVehicle, position, Quaternion.identity, transform);
        selectedVehicle.gameObject.SetActive(false);
    }

    public void DestroyVehicle()
    {
        Destroy(selectedVehicle);
    }
}
