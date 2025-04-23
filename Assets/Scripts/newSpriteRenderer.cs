using UnityEngine;

public class PlayerSpriteLoader : MonoBehaviour
{
    public Sprite candySprite;
    public Sprite onigiriSprite;
    public Sprite breadSprite;
    public Sprite radishSprite;

    public Color colorOption0;
    public Color colorOption1;
    public Color colorOption2;
    public Color colorOption3;

    void Start()
    {
        SpriteRenderer ren = GetComponent<SpriteRenderer>();
        int spriteChoice = PlayerPrefs.GetInt("spriteChoice", 1);
        int colorChoice = PlayerPrefs.GetInt("spriteColor", 0);
        
        switch (spriteChoice)
        {
            case 0: ren.sprite = candySprite; break;
            case 1: ren.sprite = onigiriSprite; break;
            case 2: ren.sprite = breadSprite; break;
            case 3: ren.sprite = radishSprite; break;
            default: ren.sprite = candySprite; break;
        }

        switch (colorChoice)
        {
            case 0: ren.color = colorOption0; break;
            case 1: ren.color = colorOption1; break;
            case 2: ren.color = colorOption2; break;
            case 3: ren.color = colorOption3; break;
            default: ren.color = colorOption0; break;
        }
    }
}

