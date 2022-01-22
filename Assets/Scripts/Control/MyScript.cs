using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    protected Joysticks joystick;
    protected JoyButton joybutton;
    protected Rigidbody playerRigidbody;

    // Use this for initialization
    void Start () {
        joystick = FindObjectOfType<Joysticks>();
        joybutton = FindObjectOfType<JoyButton>();
    }
	
	// Update is called once per frame
	void Update () {
        playerRigidbody = GetComponent<Rigidbody>();
        playerRigidbody.velocity = new Vector3(joystick.Horizontal * 100f,
                                        playerRigidbody.velocity.y,
                                        joystick.Vertical * 100f);
	}
}
