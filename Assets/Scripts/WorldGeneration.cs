using UnityEngine;
using System.Collections;

public class WorldGeneration : MonoBehaviour {

    var prefab; GameObject;
    var segmentPrefabCount = 10;
    var pieceLength = 20.0f;
    var startPositionOffset = Vector3(0, 0, 0);
    private var pieceNumber = 0;


    function Start()
    {
        // Create a new segment every 10 seconds
        InvokeRepeating("CreateSegment", 10f, 10f);
    }


    function CreateSegment()
    {
        // Create a segment with segmentPrefabCount amount of prefabs
        for (var i = 0; i < segmentPrefabCount; i++)
        {
            CreatePiece();
        }
    }

    function CreatePiece()
    {
        // Position for this piece will be the startPositionOffset plus the length of a prefab times it's index
        // Change Vector3.forward to whichever direction you need (e.g. -Vector3.up)
        var segmentPosition = startPositionOffset + Vector3.forward * (pieceNumber * pieceLength);
        Instantiate(prefab, segmentPosition, Quaternion.identity);
        pieceNumber++;
    }
}
