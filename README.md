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

## Animating the Bird

1. select Bird GameObject & creating Animation Idle & start Record animation
2. under animation window, Add Property -> Sprite Renderer -> Sprite 
2. delete the second frame of 1.00second sprite of Idle animation
3. copy first frame of Idle
4. select Bird GameObject & creating Animation Flap
5. Paste copied frame , change Sprite Renderer->Sprite to Bird_hero_1
6. create Die animation is the same way of Flap, just change Sprite to Bird_hero_2
7. open Animatior window, make transation between Idle
8. Idle->Flap : Conditions: Flap Trigger, unselect Has the ExitTime
9. Idle->Die : Conditions: Die Trigger,  unselect Has the ExitTime
10. Flap->Idle

```

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdLive : MonoBehaviour {
    private float upForce = 200f;
	private bool isDead = false;
	private Rigidbody2D rb2d;
    private Animator anim; //

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> (); //

	}
	
	// Update is called once per frame
	void Update () {
        if(!isDead){
            if(Input.GetMouseButtonDown(0)){
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger("Flap"); //
            }
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
		anim.SetTrigger("Die"); //
	}
}


```




