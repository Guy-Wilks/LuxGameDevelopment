using UnityEngine;

public class CharacterRenderer
{
    private SpriteRenderer renderers;
    private Sprite sprite;

    public CharacterRenderer(Sprite importedSprite)
    {
        sprite = importedSprite;
    }

    // Use this for initialization
    public void firstRender(Sprite impsprite, SpriteRenderer rend)
    {
        renderers = rend;
        renderers.sprite = impsprite;
    }

    public void SubRender(Vector3 newPos, SpriteRenderer rend, Transform where)
    {
        where.position = newPos;
    }
}