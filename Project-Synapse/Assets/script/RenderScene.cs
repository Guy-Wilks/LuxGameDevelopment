using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderScene : MonoBehaviour {
	public Sprite sprite;
	// Use this for initialization
	public bool rendered;
	void Start () {
		rendered = false;
		var backRender = gameObject.AddComponent<SpriteRenderer>();
		backRender.sprite = sprite;
		var size = gameObject.GetComponent<Transform>();
 		//size.localScale = new Vector2(1980/sprite.rect.width, 1080/sprite.rect.height);
		rendered = true;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
