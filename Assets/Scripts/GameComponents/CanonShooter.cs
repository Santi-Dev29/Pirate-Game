using UnityEngine;

public class CanonShooter : MonoBehaviour, ITouch
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTouchBegan(Vector2 worldPos)
    {
        Debug.Log("Disparo cañon");
    }

    public void OnTouchEnded(Vector2 worldPos)
    {

    }
}
