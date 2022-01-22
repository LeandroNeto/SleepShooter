using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joysticks joystick;

	void Update () 
	{
        Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
	}
}