
using UnityEngine;

public class layercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.Find("male character").GetComponent<Rigidbody2D>();
        self=GetComponent<Rigidbody2D>();
        Male=FindObjectOfType<male>();
    }
    private Rigidbody2D player;
    private Rigidbody2D self;
    public float screenspd;
    private male Male;

    // Update is called once per frame
    void Update()
    {
        if (Male.barriertouch==false)
        {
         self.velocity=new Vector2(-player.velocity.x*screenspd,0);   
        }
        else
        {
            self.velocity=new Vector2(0,0);
        }
    }
}
