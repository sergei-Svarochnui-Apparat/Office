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
        if (isOn) return "������� [E] ����� <color=red>����</color> ����";
        return "������� [E] ����� <color=green>���</color> ����";
    }
    public void Interact()
    {
        isOn = !isOn;
        _Light.enabled = isOn;
    }
}
