using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLauncher : MonoBehaviour
{
    public Launcher Launcher;

    // Update is called once per frame
    void Update()
    {
        // if mouse is clicked
        if (!Game.IsGameStarted())
            return;

        if (Mouse.current == null)
            return;
        
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Launch();
        }
        // launch ball
        
    }

    private void Launch()
    {
        // figure out the direction to aim
        Vector2 aimDirection = GetAimDirection();

        // launch in that direction
        Launcher.Launch(aimDirection);
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
    
}
