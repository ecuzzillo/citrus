using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class placeable : MonoBehaviour
{
    public AudioSource src;
    public Rigidbody2D pivotrb;
    public GameObject pivot;
    public Rigidbody2D rb;
    public List<Transform> anchorPoints;

    public void MyOnMouseDown()
    {
        var mousePos = Input.mousePosition;

        var hinge = pivot.AddComponent<HingeJoint2D>();
        hinge.autoConfigureConnectedAnchor = false;

        hinge.connectedBody = rb;

        hinge.connectedAnchor = transform.InverseTransformPoint(Camera.main.ScreenToWorldPoint(mousePos));
        hinge.enabled = true;
    }

    public void detach()
    {
        Debug.Log("SUP");
        Destroy(pivot.GetComponent<HingeJoint2D>());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }
}
