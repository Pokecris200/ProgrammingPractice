using UnityEngine;
using UnityEngine.Rendering;

public class NPCCars : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed, ForceMode.Acceleration);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DespawnPoint"))
        {
            Destroy(gameObject);
        }
    }
}
