using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private Vector3 _scaleParameters;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += _scaleParameters * _scaleSpeed * Time.deltaTime;
    }
}
