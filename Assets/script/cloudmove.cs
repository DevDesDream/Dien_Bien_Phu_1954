
using UnityEngine;

public class cloudmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        cloudspawnpos=GameObject.Find("cloudspawn");
        self = GetComponent<Rigidbody2D>();
        time=0;
        transform.SetParent(cloudspawnpos.transform);
        selfpos=GetComponent<Transform>();
        randomposx=Random.Range(-1f,1f);
        randomposy=Random.Range(-0.5f,0.5f);
        selfpos.position=new Vector3(selfpos.position.x+randomposx,selfpos.position.y+randomposy,selfpos.position.z);
        player= GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>();
        Male=FindObjectOfType<male>();
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
    public male Male;
    void Update()
    {
        time+=Time.deltaTime;
        if (Male.barriertouch==false)
        {
        self.velocity= new Vector2(cloudspeed-player.velocity.x/7,0);
        }
        else 
        {
          self.velocity= new Vector2(cloudspeed,0);  
        }
        if (self.position.x<GameObject.FindWithTag("Player").transform.position.x-20)
        {
            Destroy(gameObject);
        }
    }
}
