using UnityEngine;

public class Slot : MonoBehaviour
{
    public UI Ui;
    public int Points = 10;
    public GameObject FireworksParticlePrefab;
    public Sounds Sounds;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D other)
    {
        ScorePoints();
        SpawnParticles(other);
        Sounds.PlayFireworksSound();
    }

    private void SpawnParticles(Collider2D other)
    {
        Vector3 particlePosition = GetParticlePosition(other);
        Instantiate(FireworksParticlePrefab, particlePosition, Quaternion.identity);
    }

    private Vector3 GetParticlePosition(Collider2D other)
    {
        Vector3 ballPosition = other.transform.position;
        ballPosition.y += 0.25f;
        return ballPosition;
    }

    private void ScorePoints()
    {
        ScoreKeeper.Add(Points);
        Ui.ShowScore(ScoreKeeper.GetScore());
    }
}
