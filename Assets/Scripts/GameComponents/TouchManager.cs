using UnityEngine;
using UnityEngine.InputSystem;   // Nuevo Input System

public class TouchManager : MonoBehaviour
{
    void Update()
    {
        // MOBILE TOUCH
        if (Touchscreen.current != null && Touchscreen.current.touches.Count > 0)
        {
            var t = Touchscreen.current.touches[0].ReadValue();

            if (t.phase == UnityEngine.InputSystem.TouchPhase.Began)
            {
                Vector2 screenPos = t.position;
                Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                TouchChecker(worldPos);
            }
        }

        // PC CLICK (Testing or port)
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 screenPos = Mouse.current.position.ReadValue();
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
            TouchChecker(worldPos);
        }
    }

    void TouchChecker(Vector2 worldPos)
    {
        Collider2D hit = Physics2D.OverlapPoint(worldPos);

        if (hit != null)
        {
            ITouch receiver = hit.GetComponent<ITouch>();
            if (receiver != null)
            {
                receiver.OnTouchBegan(worldPos);
            }
        }
    }
}