using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _growthSpeed;

    void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime, Space.World);
        transform.RotateAround(transform.position, transform.up, _rotationSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_growthSpeed, _growthSpeed, _growthSpeed) * Time.deltaTime; 
    }
}
