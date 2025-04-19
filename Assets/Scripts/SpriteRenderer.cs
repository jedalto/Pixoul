using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteLoader : MonoBehaviour
{
    public Sprite whiteSprite;
    public Sprite graySprite;

    public Color colorOption0 = Color.cyan;
    public Color colorOption1 = Color.yellow;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer ren = GetComponent<SpriteRenderer>();
        int spriteChoice = PlayerPrefs.GetInt("spriteChoice", 1);
        int colorChoice = PlayerPrefs.GetInt("spriteColor", 1);

        if (spriteChoice == 0)
            ren.sprite = whiteSprite;
        else
            ren.sprite = graySprite;

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
