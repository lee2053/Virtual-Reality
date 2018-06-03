// TravelPointToMove.cs
// When the Vive hand-held controller's menu button is pressed, move the "movee" in the direction of the wand
// Usually the "movee" will be the Player (e.g. [CameraRig])
// Attach this script to a Vive Controller

using UnityEngine;
using System.Collections;

public class TravelPointToMove : MonoBehaviour {

	public GameObject movee;						// Object which is moved (should be [CameraRig])
	public bool travelling = false;					// flag whether we are currently travelling
	private Vector3 speed = Vector3.forward * 0.03F;// Fixed travel rate

	// When game is initialized, find the TrackedController component, and
	//    add Menu & Grip handler methods to it's operations
	private SteamVR_TrackedController device;		// Reference to the Vive Controller inputs
	void Start () {
		device = GetComponent<SteamVR_TrackedController>();
		device.MenuButtonClicked += MenuButtonClicked;
		device.MenuButtonUnclicked += MenuButtonUnclicked;
	
	}

	void Update() {
		Vector3 moveby;
		if (travelling) {
			moveby = this.transform.rotation * speed;
			moveby.y = 0.0f;
			movee.transform.Translate(moveby);
		}
	}

	void MenuButtonClicked (object sender, ClickedEventArgs e)
	{
		Debug.Log ("Menu button has been pressed");	
		travelling = true;
	}
	void MenuButtonUnclicked (object sender, ClickedEventArgs e)
	{
		Debug.Log ("Menu button has been released");	
		travelling = false;
	}

}
