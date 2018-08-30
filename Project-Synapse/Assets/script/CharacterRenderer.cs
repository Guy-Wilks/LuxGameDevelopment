using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRenderer{
	private Transform spot;
	private Sprite sprite;
	private SpriteRenderer renderers;
	public CharacterRenderer(Sprite importedSprite){
		sprite = importedSprite;
	}
	// Use this for initialization
	public void firstRender(Sprite impsprite, SpriteRenderer rend) {
		renderers = rend;
		renderers.sprite =impsprite;
	}
	public void SubRender(Vector3 newPos, SpriteRenderer rend, Transform where){
		where.position = newPos;
	}
	public Transform getSpot(){
		return spot;
	}
}
