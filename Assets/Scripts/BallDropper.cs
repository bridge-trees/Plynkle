using UnityEngine;
using UnityEngine.InputSystem;

public class BallDropper : MonoBehaviour
{
    public GameObject BallPrefab;
    // Update is called once per frame
    void Update()
    {
        if (Game.IsGameStarted() && Mouse.current.leftButton.wasPressedThisFrame)
        {
            DropBall();
        }
        
    }

    private void DropBall()
    {
        Vector3 spawnPosition = GetSpawnPosition();
        
        GameObject ball = Instantiate(BallPrefab, spawnPosition, Quaternion.identity);

        AddRandomForce(ball);
    }

    private void AddRandomForce(GameObject ball)
    {
        Rigidbody2D rigidbody = ball.GetComponent<Rigidbody2D>();
        
        float randomHorizontalForce = Random.Range(-5f, 5f);
        rigidbody.AddForce(new Vector2(randomHorizontalForce, 0f), ForceMode2D.Impulse);
    }

    private Vector3 GetSpawnPosition()
    {
        Vector3 leftEdge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 rightEdge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Camera.main.nearClipPlane));
        
        float randomX = Random.Range(leftEdge.x + 1, rightEdge.x - 1);
        
        Vector3 spawnPosition = new Vector3(randomX, 4.5f, 0f);
        return spawnPosition;
    }
}
