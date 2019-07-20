using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placeable : MonoBehaviour
{
    public AudioSource src;
    public Rigidbody2D pivotrb;
    public GameObject pivot;
    public Rigidbody2D rb;



    public void MyOnMouseDown()
    {
        Debug.Log("happened");
        Debug.Log(this.name);
        var mousePos = Input.mousePosition;

        var hinge = pivot.AddComponent<HingeJoint2D>();
        hinge.autoConfigureConnectedAnchor = false;

        hinge.connectedBody = rb;

        hinge.connectedAnchor = transform.InverseTransformPoint(Camera.main.ScreenToWorldPoint(mousePos));
        hinge.enabled = true;
    }

    private void OnMouseDown()
    {
        Debug.Log("wat");
        Debug.Log(this.name);
        Destroy(pivot.GetComponent<HingeJoint2D>());
    }

    private void OnMouseUp()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        src.Play();
    }
}
