
using UnityEngine;

public class pullcanon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=GetComponent<Rigidbody2D>();
        newspd=speed;
        timecount=starttime;
    }

    // Update is called once per frame
    public float duration;
    public float timecount;
    public float starttime;
    private Rigidbody2D self;
    public float newspd;
    public float speed;
    void Update()
    {
        timecount+=Time.deltaTime;
        if (timecount>=duration)
        {
            timecount=0;
            newspd=speed;
    
        }
        else
        {
            if (newspd>0)
            {
             newspd-=Time.deltaTime;
        
            }
        }
        self.velocity=new Vector2(newspd,self.velocity.y);
    }
}
