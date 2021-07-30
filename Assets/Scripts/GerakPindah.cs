using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPindah : MonoBehaviour
{
    private float speed = 3f;
    public Sprite[] sprites;

    private Vector3 screenPoint;
    private Vector3 offset;
    private float firstY;

    private SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    private void Start () 
    {
        //Assign a randomize sprite to game object's sprite renderer
        int index = Random.Range(0, sprites.Length);
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[index];
    }

    // Update is called once per frame
    private void Update()
    {
        // Move game object to the left
        float move = (speed * Time.deltaTime * -1f) + transform.position.x;
        transform.position = new Vector3(move, transform.position.y);
    }

    // If the mouse start click the game object
    private void OnMouseDown()
    {
        // Assign the initial game object's Y position
        firstY = transform.position.y;

        // Assign game object screen position
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        
        // Assign mouse click offset
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    // Drag the game object follows the mouse cursor
    private void OnMouseDrag()
    {
        //Get mouse position and assign it to the game object position
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }
    
    // If the mouse release the click, drop the game object to its initial y position
    private void OnMouseUp()
    {
        transform.position = new Vector3(transform.position.x, firstY, transform.position.z);
    }
}
