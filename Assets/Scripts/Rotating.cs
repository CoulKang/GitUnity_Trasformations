using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour
{
    [SerializeField] private float _rotatingSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotatingSpeed * Time.deltaTime);
    }
}
