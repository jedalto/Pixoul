using UnityEngine;

public class GroundTextureManager : MonoBehaviour
{
    public Sprite grassTexture;
    public Sprite hardwoodTexture;
    public Sprite carpetTexture;
    public Sprite cloudTexture;

    private void Start()
    {
        // Get ALL SpriteRenderers in children of this GameObject
        SpriteRenderer[] childRenderers = GetComponentsInChildren<SpriteRenderer>();

        int spriteChoice = PlayerPrefs.GetInt("groundTextureChoice", 0);
        Sprite selectedSprite = grassTexture; // Default

        switch (spriteChoice)
        {
            case 0: selectedSprite = grassTexture; break;
            case 1: selectedSprite = hardwoodTexture; break;
            case 2: selectedSprite = carpetTexture; break;
            case 3: selectedSprite = cloudTexture; break;
            default: selectedSprite = hardwoodTexture; break;
        }

        // Apply to all child SpriteRenderers
        foreach (SpriteRenderer ren in childRenderers)
        {
            ren.sprite = selectedSprite;
        }
    }
}
