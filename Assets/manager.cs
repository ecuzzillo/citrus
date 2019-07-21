using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public GameObject attached;
    public bool attachedThisFrame = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void attach(GameObject obj)
    {
        attachedThisFrame = true;
        attached = obj;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && attached != null && !attachedThisFrame)
        {
            var obj = attached.GetComponent<placeable>();
            obj.detach();
            attached = null;
            Debug.Log("MOUSY BOY");
        }

        attachedThisFrame = false;
    }
}
