using System.Runtime.CompilerServices;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
}
