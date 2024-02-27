using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;

    private void Update()
    {
        transform.localScale += new Vector3(_growthSpeed, _growthSpeed, _growthSpeed) * Time.deltaTime;
    }
}
