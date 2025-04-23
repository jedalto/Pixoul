using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLoader : MonoBehaviour
{
    public Sprite onigiriSprite;
    public Sprite candySprite;
    public Sprite breadSprite;
    public Sprite raddishSprite;

    public Color colorOption0 = Color.white;
    public Color colorOption1 = Color.yellow;
    public Color colorOption2;
    public Color colorOption3;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer ren = GetComponent<SpriteRenderer>();
        int spriteChoice = PlayerPrefs.GetInt("spriteChoice", 1);
        int colorChoice = PlayerPrefs.GetInt("spriteColor", 1);

        if (spriteChoice == 0)
            ren.sprite = candySprite;
        else if (spriteChoice == 2) 
            ren.sprite = onigiriSprite;
        else
        {
            ren.sprite = breadSprite;
        }

        if (colorChoice == 0)
            ren.color = colorOption0;
        else
            ren.color = colorOption1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
