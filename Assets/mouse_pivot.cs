using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_pivot : MonoBehaviour
{
    public Vector2 mousePos;
    public Vector3 worldPos;

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        var cam = Camera.main;
        worldPos = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        if (mousePos.x >= 0 && mousePos.y >= 0 && mousePos.x < Screen.width && mousePos.y < Screen.height)
        {
            transform.position = worldPos;
        }
    }
}
