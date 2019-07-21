using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuItem : MonoBehaviour
{
    public Transform target;
    public GameObject pivot;
    public Rigidbody2D pivotrb;
    public manager mgr;

    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = target.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnMouseDown()
    {
        if (!mgr.attached)
        {
            var item = Instantiate(target, transform.position, transform.rotation);
            var instantiatedItem = item.GetComponent<placeable>();
            instantiatedItem.pivot = pivot;
            instantiatedItem.pivotrb = pivotrb;
            instantiatedItem.rb.isKinematic = false;
            instantiatedItem.MyOnMouseDown();
            mgr.attach(item.gameObject);
        }
    }
}
