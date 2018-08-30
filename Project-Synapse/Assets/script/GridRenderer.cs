using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridRenderer : MonoBehaviour {
	private Vector3 gridScale;
	private Grid grid;
	public bool rendered;
	private Transform translations;
	// Use this for initialization
	void Start () {
		rendered = false;
		gridScale = new Vector3((float)0.86, (float)0.95, 1);
		var newPos = new Vector3((float)1.31, (float)-0.48,(float)-0.01171);
		grid = gameObject.AddComponent<Grid>();
		translations = gameObject.GetComponent<Transform>();
		translations.position = (newPos);
		grid.cellSize = gridScale;
		rendered = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
