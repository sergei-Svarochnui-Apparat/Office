using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanCycle : MonoBehaviour
{
    public float RotationSize = 100f;
    void Update()
    {
        transform.Rotate(0, RotationSize * Time.deltaTime, 0);
    }
}
