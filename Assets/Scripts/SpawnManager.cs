using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject carPrefab;
    private bool spawnLeft = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnCar", 2.0f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCar()
    {
        float offset;
        if (spawnLeft)
        {
            offset = -4f;
            spawnLeft = false;
        }
        else
        {
            offset = 4f;
            spawnLeft = true;
        }
        Vector3 SpawnPoint = new Vector3(transform.position.x + offset, 0.2f, transform.position.z);
        Instantiate(carPrefab, SpawnPoint, carPrefab.transform.rotation);
    }
}
