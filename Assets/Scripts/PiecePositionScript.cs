using UnityEngine;

public class PiecePositionScript : MonoBehaviour
{
    public Transform objectToInheritFrom; // Assign the object you want to inherit the position from in the Inspector.

    void Update()
    {
        // Check if the object to inherit from exists.
        if (objectToInheritFrom != null)
        {
            // Set the position of this object to match the position of the object to inherit from.
            transform.position = objectToInheritFrom.position;
        }
    }
}