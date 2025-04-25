using UnityEngine;

public class expressionManager : MonoBehaviour
{
    public Sprite happy;
    public Sprite grumpy;
    public Sprite evil;
    public Sprite meh;

    private void Start()
    {
        int expressionChoice = PlayerPrefs.GetInt("expressionChoice", 0);
        SpriteRenderer ren = GetComponent<SpriteRenderer>();

        switch (expressionChoice)
        {
            case 0: ren.sprite = happy; break;
            case 1: ren.sprite = grumpy; break;
            case 2: ren.sprite = evil; break;
            case 3: ren.sprite = meh; break;
            default: ren.sprite = happy; break;
        }
    }
}
