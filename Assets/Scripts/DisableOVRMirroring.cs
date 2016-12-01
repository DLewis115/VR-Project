using UnityEngine;
using System.Collections;

public class DisableOVRMirroring : MonoBehaviour {
    IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        UnityEngine.VR.VRSettings.showDeviceView = false;
    }
}
