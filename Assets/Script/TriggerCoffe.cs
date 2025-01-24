using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCoffe : MonoBehaviour
{
    public GameObject gameObj;
    public GameObject HidegameObj;
    private void OnTriggerEnter(Collider other)
    {
        gameObj.SetActive(true);
        HidegameObj.SetActive(false);
    }
}
