using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeTrack : MonoBehaviour
{
    private Transform m_transform;
    // Start is called before the first frame update
    private void Start()
    {
        m_transform = this.transform;
    }

    private void LAMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint (Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //this is the angle that the object must rotate around to face the cursor
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); //Vector 3.forward is z axis
        m_transform.rotation = rotation;
    }
    // Update is called once per frame
    void Update()
    {
        LAMouse();
    }
}
