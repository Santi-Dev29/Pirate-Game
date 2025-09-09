
using UnityEngine;
public interface ITouch
{
    // Enter Touch
    void OnTouchBegan(Vector2 worldPos);

    //Exit Touch
    void OnTouchEnded(Vector2 worldPos);
}