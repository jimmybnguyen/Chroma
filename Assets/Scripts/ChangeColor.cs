using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    public SteamVR_TrackedObject rightController;
    public ColorManager cm;

    void Update()
    {
    }
    void OnTriggerStay(Collider col) {
        SteamVR_Controller.Device device = SteamVR_Controller.Input((int)rightController.index);
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            GetComponent<Renderer>().material.color = cm.color;
        }
	}
}
