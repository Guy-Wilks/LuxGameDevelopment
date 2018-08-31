using UnityEngine;

public class CharTmpl
{
    public CharTmpl(string importedName, string importedClass)
    {
        charName = importedName;
        charClass = importedClass;
    }

    private string charName { get; set; }

    private string charClass { get; set; }

    private int[] stats { get; set; }

    public void move(CharTmpl chars, CharacterRenderer newRend, SpriteRenderer rend, Transform where)
    {
        if (Input.anyKeyDown)
            if (Input.GetMouseButtonDown(0))
                where.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    }
}