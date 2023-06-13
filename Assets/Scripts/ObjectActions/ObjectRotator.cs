using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 1f;
    [SerializeField] private Vector3 rotationAxis = Vector3.up;

    public void RotateObject(Transform objectToRotate, float deltaTouchPosition)
    {
        float rotationAmount = deltaTouchPosition * rotationSpeed * Time.deltaTime;
        objectToRotate.Rotate(rotationAxis, rotationAmount);
    }
}
