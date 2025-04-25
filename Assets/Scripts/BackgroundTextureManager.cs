using UnityEngine;

public class BackgroundTextureManager : MonoBehaviour
{
    public Sprite librarySprite;
    public Sprite nightSkySprite;
    public Sprite forestSprite;
    public Sprite spiderwebSprite;

    void Start()
    {
        SpriteRenderer ren = GetComponent<SpriteRenderer>();
        int backgroundChoice = PlayerPrefs.GetInt("backgroundTextureChoice", 0);

        switch (backgroundChoice)
        {
            case 0: ren.sprite = librarySprite; break;
            case 1: ren.sprite = forestSprite; break;
            case 2: ren.sprite = nightSkySprite; break;
            case 3: ren.sprite = spiderwebSprite; break;
            default: ren.sprite = spiderwebSprite; break;
        }
    }
}
