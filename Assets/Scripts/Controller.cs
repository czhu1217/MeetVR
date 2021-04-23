using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject camera;

    public const float WALK_SPD = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        Vector3 movement = camera.transform.TransformDirection(-input.x, 0, -input.y);
        movement.y = 0;
        movement = movement.magnitude == 0 ? Vector3.zero : movement / movement.magnitude;
        movement *= Time.deltaTime * WALK_SPD;
        this.transform.Translate(movement);
    }
}
