using System;
using UnityEngine;

public class HackyScaleFix : MonoBehaviour
{
    private Vector3 _scaleChange;

    private void Awake()
    {
        _scaleChange = transform.localScale;
    }

    private void FixedUpdate()
    {
        if ((0.1f < transform.localScale.x || transform.localScale.x > 1.01) 
            || (0.1f < transform.localScale.y || transform.localScale.y > 1.01) 
            || (0.1f < transform.localScale.z || transform.localScale.z > 1.01))
        {
            transform.localScale = _scaleChange;
        }
    }
}
