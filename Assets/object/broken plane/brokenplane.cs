
using UnityEngine;

public class brokenplane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=GetComponent<Rigidbody2D>();
    }
    public male male;
    private Rigidbody2D self;
    public Rigidbody2D player;

    // Update is called once per frame
    void Update()
    {
        if (male.barriertouch==false)
        {
          self.velocity=new Vector2(-player.velocity.x*0.05f,-player.velocity.y*0.05f);
        }
        else
        {
            self.velocity= new Vector2(0,0);
        }
    }
}
