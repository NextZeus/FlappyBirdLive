
Input.GetMouseButtonDown(0) 鼠标左键
rb2d.AddForce(new Vector2(0, 100f)); //Y轴方向施力
anmi.SetTrigger("Flap"); //出发Flap animation Clip
OnCollisionEnter2D(Collision2D collision) //碰撞检测

public static GameController instance;

void Awake()
{
    if( instance == null){
        instance = this;
    } else if(instance != this){
        Destroy(gameObject);
    }   
}

<!-- scene manager -->
using UnityEngine.SceneManagement;
<!-- load scene by index -->
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

<!-- display gameOverText -->
gameOverText.SetActive(true);

<!-- instance gameObject batch with prefab-->
void Start () {
    columns = new GameObject[columnPoolSize];
    for (int i = 0; i < columnPoolSize; i++)
    {
        columns[i] = (GameObject) Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
    }
}

<!-- Quaternion -->

<!-- repeat background -->
private BoxCollider2D groundCollider;
private float groundHorizontalLength;

// Use this for initialization
void Start () {
    groundCollider = GetComponent<BoxCollider2D>();
    groundHorizontalLength = groundCollider.size.x;
}

// Update is called once per frame
void Update () {
    if(transform.position.x < -groundHorizontalLength){
        RepatingBackGround();
    }
}

private void RepatingBackGround(){
    Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
    transform.position = (Vector2)transform.position + groundOffset;
}