using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharManager : MonoBehaviour {
	public string charName;
	public string charClass;
	public Sprite sprite;
	// Use this for initialization
	private CharTmpl Marth;
	private CharacterRenderer rend;
	private SpriteRenderer rends;
	private Transform wheres;
	void Start () {
		Marth = new CharTmpl(charName, charClass);
		rend = new CharacterRenderer(sprite);
		rends = gameObject.AddComponent<SpriteRenderer>();
		var wheres = gameObject.GetComponent<Transform>();
		rend.firstRender(sprite, rends);
		wheres.position = new Vector2(0,0);
	}
	
	// Update is called once per frame
	void Update () {
		wheres = gameObject.GetComponent<Transform>();
		if(Input.GetMouseButtonDown(0)){
				wheres.localPosition  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				wheres.Translate(new Vector3(0,0,10), new Space());
			}
	}
	
}
