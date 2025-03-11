
using UnityEngine;

public class cloudbacklayermove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cloudspawnpos=GameObject.Find("cloudspawnfar");
        self = GetComponent<Rigidbody2D>();
        time=0;
        transform.SetParent(cloudspawnpos.transform);
        selfpos=GetComponent<Transform>();
        randomposx=Random.Range(-1f,1f);
        randomposy=Random.Range(-0.75f,0.75f);
        selfpos.position=new Vector3(selfpos.position.x+randomposx,selfpos.position.y+randomposy,selfpos.position.z);
        player= GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        male=FindAnyObjectByType<male>();
    }

    // Update is called once per frame
    private Rigidbody2D self;
    public float cloudspeed;
    public float time;
    public GameObject cloudspawnpos;
    private float randomposx;
    private float randomposy;
    private Transform selfpos;
    public Rigidbody2D player;
    public male male;
    void Update()
    {
        time+=Time.deltaTime;
        if (male.barriertouch==false)
        {
        self.velocity= new Vector2(cloudspeed-player.velocity.x/10,0);
        }
        else 
        {
            self.velocity=new Vector2(cloudspeed,0);
        }
        if (self.position.x<GameObject.FindWithTag("Player").transform.position.x-15)
        {
            Destroy(gameObject);
        }
    }
}
