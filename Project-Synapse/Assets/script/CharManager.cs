using UnityEngine;
using System;

public class CharManager : MonoBehaviour
{
    public string charClass;
    public string charName;

    // Use this for initialization
    private CharTmpl Marth;
    private CharacterRenderer rend;
    private SpriteRenderer rends;

    public Sprite sprite;
    private Transform wheres;

    private void Start()
    {
        Marth = new CharTmpl(charName, charClass);
        rend = new CharacterRenderer(sprite);
        rends = gameObject.AddComponent<SpriteRenderer>();
        var wheres = gameObject.GetComponent<Transform>();
        rend.firstRender(sprite, rends);
        wheres.position = new Vector2(0, 0);
        wheres.localScale = (new Vector2((float)0.61,(float)0.51));
    }

    // Update is called once per frame
    private void Update()
    {
        wheres = gameObject.GetComponent<Transform>();
        if (Input.GetMouseButtonDown(0))
        {
            wheres.localPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            wheres.Translate(new Vector3(0, 0, 9), new Space());
            snapToGrid(wheres);
        }
    }

    public void snapToGrid(Transform trans)
    {
        double newPosX = 0;
        double newPosY = 0;
        
            newPosX = Math.Floor(trans.position.x) +0.5;
            newPosY = Math.Floor(trans.position.y)+0.5;
        

        trans.position = (new Vector3((float)newPosX, (float)newPosY, 0));
    }
}