using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuItem : MonoBehaviour
{
    public Transform target;
    public GameObject pivot;
    public Rigidbody2D pivotrb;
    // Start is called before the first frame update
    void Start()
    {
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = target.GetComponent<SpriteRenderer>().sprite;

    }

    private void OnMouseDown()
    {
        var item = Instantiate(target, transform.position, transform.rotation);
        var instantiatedItem = item.GetComponent<placeable>();
        instantiatedItem.pivot = pivot;
        instantiatedItem.pivotrb = pivotrb;
        instantiatedItem.rb.isKinematic = false;

        Debug.Log("happened 2");
        instantiatedItem.MyOnMouseDown();
        /*var clone = Instantiate(gameObject);
        Destroy(clone.GetComponent<menuItem>());
        var otherbox = clone.GetComponent<box>();
        otherbox.enabled = true;
        otherbox.MyOnMouseDown();
        clone.GetComponent<BoxCollider2D>().enabled = true;
        */
    }
}
