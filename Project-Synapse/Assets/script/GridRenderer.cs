using UnityEngine;

public class GridRenderer : MonoBehaviour
{
    private Grid grid;
    private Vector3 gridScale;
    public bool rendered;

    private Transform translations;

    // Use this for initialization
    private void Start()
    {
        rendered = false;
        gridScale = new Vector3(1, 1, 1);
        var newPos = new Vector3(0, 0, 0);
        grid = gameObject.AddComponent<Grid>();
        translations = gameObject.GetComponent<Transform>();
        translations.position = newPos;
        grid.cellSize = gridScale;
        rendered = true;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}