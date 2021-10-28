 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float xSpeed = 10f;
    public float ySpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        if (!Mathf.Approximately(horizontal, 0))
        {
            float xOffset = horizontal * Time.deltaTime * xSpeed;
            float xNewPos = xOffset + transform.localPosition.x;
            transform.localPosition = new Vector3(Mathf.Clamp(xNewPos,-10,10), transform.localPosition.y, transform.localPosition.z);
        }

        float vertical = CrossPlatformInputManager.GetAxis("Vertical");
        if (!Mathf.Approximately(vertical, 0))
        {
            float yOffset = vertical * Time.deltaTime * ySpeed;
            float yNewPos = yOffset + transform.localPosition.y;
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Clamp(yNewPos, -10, 10), transform.localPosition.z);
        }

    }
}
