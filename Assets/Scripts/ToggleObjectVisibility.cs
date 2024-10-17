using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectVisibility : MonoBehaviour
{
    public GameObject object_to_toggle;

    public void ToggleVisible()
    {
        object_to_toggle.SetActive(!object_to_toggle.activeSelf);
    }
}