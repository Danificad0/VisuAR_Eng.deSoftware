using UnityEngine;

public class ObjectManipulator : MonoBehaviour, ITransformManipulator
{
    [SerializeField] private Transform objectToManipulate;
    [SerializeField] private ObjectRotator rotator;
    [SerializeField] private ObjectScaler scaler;

    private Vector2 initialTouchPosition;
    private bool isRotating = false;

    public void ManipulateObject(Transform objectToManipulate, Vector2 deltaTouchPosition)
    {
        if (!isRotating && Mathf.Abs(deltaTouchPosition.x) > Mathf.Abs(deltaTouchPosition.y))
        {
            isRotating = true;
        }

        if (isRotating)
        {
            rotator.RotateObject(objectToManipulate, deltaTouchPosition.x);
        }
        else
        {
            scaler.ScaleObject(objectToManipulate, deltaTouchPosition);
        }
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    initialTouchPosition = touch.position;
                    isRotating = false;
                    break;

                case TouchPhase.Moved:
                    Vector2 currentTouchPosition = touch.position;
                    Vector2 deltaTouchPosition = currentTouchPosition - initialTouchPosition;

                    ManipulateObject(objectToManipulate, deltaTouchPosition);
                    break;

                case TouchPhase.Ended:
                    isRotating = false;
                    break;
            }
        }
    }
}