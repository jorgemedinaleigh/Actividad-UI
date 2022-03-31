using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformOscillator : MonoBehaviour
{
    Vector3 startingPosition;
    float movementFactor;
    [SerializeField] float period = 2f;
    [SerializeField] Vector3 movementVector;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (period <= Mathf.Epsilon) //Epsilon = the smallest number of type float
        {
            return;
        }

        float cycles = Time.time / period;
        const float tau = Mathf.PI * 2f;
        float rawSinWave = Mathf.Sin(cycles * tau);

        movementFactor = (rawSinWave + 1f) / 2f;

        Vector3 offset = movementVector * movementFactor;
        transform.position = startingPosition + offset;
    }
}
