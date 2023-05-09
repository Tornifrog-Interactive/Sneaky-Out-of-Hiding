using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Use this for initialization
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(
            new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z)
        ); // screen bounds
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; // object width
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; // object height
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(
            viewPos.x,
            screenBounds.x * -1 + objectWidth,
            screenBounds.x - objectWidth
        );
        viewPos.y = Mathf.Clamp(
            viewPos.y,
            screenBounds.y * -1 + objectHeight,
            screenBounds.y - objectHeight
        );
        transform.position = viewPos;
    }
}
