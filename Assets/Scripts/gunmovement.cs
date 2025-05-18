using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunmovement : MonoBehaviour
{

    private Vector2 mousePos;

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePos.y - transform.position.y, mousePos.x - transform.position.x) * Mathf.Rad2Deg - 90f;

        transform.localRotation = Quaternion.Euler(0, 0, angle + 90);
    }
}
