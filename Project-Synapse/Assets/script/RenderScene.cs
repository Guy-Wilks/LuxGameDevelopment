using UnityEngine;

public class RenderScene : MonoBehaviour
{
    // Use this for initialization
    public bool rendered;
    public Sprite sprite;

    private void Start()
    {
        rendered = false;
        var backRender = gameObject.AddComponent<SpriteRenderer>();
        backRender.sprite = sprite;
        var size = gameObject.GetComponent<Transform>();
        //size.localScale = new Vector2(1980/sprite.rect.width, 1080/sprite.rect.height);
        rendered = true;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}