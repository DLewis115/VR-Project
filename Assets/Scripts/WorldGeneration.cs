using UnityEngine;
using System.Collections;

public class WorldGeneration : MonoBehaviour {

    public GameObject[] blocks = new GameObject[4];
    const float BlockLength = 348f;

    private UnityEngine.UI.InputField my_field;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        my_field = gameObject.GetComponent<UnityEngine.UI.InputField>();
    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject block in blocks)
        {
            Vector3 newBlockPos = block.transform.position;
            newBlockPos.z -= moveSpeed * Time.deltaTime;
            if (newBlockPos.z < -BlockLength / 4)
            {
                newBlockPos.z += BlockLength;
            }
            block.transform.position = newBlockPos;
        }
	}

    public void setSpeed(float newSpeed)
    {
        moveSpeed = newSpeed/10;
    }
}
