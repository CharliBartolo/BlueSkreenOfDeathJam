using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WindowInteractions : MonoBehaviour
{
    public GameObject object_to_toggle;
    public bool hide_on_mouse_away;
    public Vector2[] mouseover_box;

    public void ToggleVisible()
    {
        object_to_toggle.SetActive(!object_to_toggle.activeSelf);
    }

    void FixedUpdate()
    {
        if (hide_on_mouse_away && object_to_toggle.activeSelf)
        {
            CheckMouseOver(mouseover_box);
        }
    }

    public void CheckMouseOver(Vector2[] box_to_check)
    {
        Vector3 mouse_pos = Input.mousePosition;
        Debug.Log($"Mouse Position: {mouse_pos}, Box to check: {box_to_check}");
        if (box_to_check.Length != 2)
        {
            Debug.Log("Box to check has incorrect number of coords, requires 2.");
            return;
        }

        if (box_to_check[0].x >= mouse_pos.x || mouse_pos.x >= box_to_check[1].x ||
            box_to_check[0].x >= mouse_pos.y || mouse_pos.y >= box_to_check[1].y)
            {
                ToggleVisible();
            }
    }
}