using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hangingRope : MonoBehaviour
{
    public bool ropeTracking;

    // Start is called before the first frame update
    void Start()
    {
        var ropeLine = GetComponent<LineRenderer>();
        ropeLine.SetWidth(.3f, .3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (ropeTracking)
        {
            var ropeLine = GetComponent<LineRenderer>();
            ropeLine.SetPosition(1, Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("");
        ropeTracking = !ropeTracking;
    }
}
