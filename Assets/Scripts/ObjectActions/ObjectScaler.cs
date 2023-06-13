using UnityEngine;

public class ObjectScaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 1f;

    public void ScaleObject(Transform objectToScale, Vector2 deltaTouchPosition)
    {
        float scaleFactor = deltaTouchPosition.y * scaleSpeed * Time.deltaTime * 0.01f;
        objectToScale.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
}
