using UnityEngine;

public interface ITransformManipulator
{
    void Manipulate(Transform transform, Vector2[] positions);
}
