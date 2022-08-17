using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("AAAA");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package");
            hasPackage = true;
            Destroy(collision.gameObject, destroyDelay);
            spriteRenderer.color = hasPackageColor;
        }

        if (collision.tag == "Customer")
        {
            Debug.Log("Customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
