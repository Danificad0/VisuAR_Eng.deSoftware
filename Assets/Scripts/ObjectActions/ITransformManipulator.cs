using UnityEngine;

public interface ITransformManipulator
{
    void ManipulateObject(Transform objectToManipulate, Vector2 deltaTouchPosition);
}