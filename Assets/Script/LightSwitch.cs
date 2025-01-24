using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class LightSwitch : MonoBehaviour, IInteractable
{
    public Light _Light;
    public bool isOn;

    void Start()
    {
        _Light.enabled = isOn;
    }
    public string GetDescripting()
    {
        if (isOn) return "Нажмите [E] чтобы <color=red>выкл</color> свет";
        return "Нажмите [E] чтобы <color=green>вкл</color> свет";
    }
    public void Interact()
    {
        isOn = !isOn;
        _Light.enabled = isOn;
    }
}
