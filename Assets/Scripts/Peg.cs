using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
    public List<Sprite> Sprites;

    private int currentSpriteNumber = 0;
    private SpriteRenderer spriteRenderer;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            OnBallHit();
        }
    }

    private void OnBallHit()
    {
        if (NoMoreSprites())
        {
            Destroy(gameObject);
        }
        else
        {
            showNextSprite();
        }
    }

    private void showNextSprite()
    {
        currentSpriteNumber++;
        spriteRenderer.sprite = Sprites[currentSpriteNumber];
    }

    private bool NoMoreSprites()
    {
        if (currentSpriteNumber == 2)
            return true;
        return false;
    }
}
