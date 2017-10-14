# Flappy Bird Game

## Adding Sprites
1. slice bird sprite to three 
2. put BirdHero_0 , GrassThinSprite to Hierarchy, put SkyTileSprite children of GrassThinSprite.
3. rename BirdHero_0 to Bird; rename GrassThinSprite to Ground; rename SkyTileSprite to SkyBackGround;
4. add Sorting Layer to Sprite; create three new Layer: Background, midGround , foreGround;
5. set Bird and Ground GameObject to foreGround Layer; set SkyBackGround to backGround Layer;
6. Bird add Rigibody Component : Add Component -> Physics 2D -> Rigibody 2D
7. Bird add Collider Component : Add Component -> Physics 2D -> Ploygon Collider 2D 
8. Ground add Collider Component: Add Component -> Physics 2D -> Box Collider 2D 
9. adjust the Box Collider Y position to match the Grass top

## The Bird Script

```

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLive : MonoBehaviour {
    private float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
        if(!isDead){
            if(Input.GetMouseButtonDown(0)){
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
    }
}


```