
using UnityEngine;

public class male : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        selfevent=GetComponent<Animator>();
        self=GetComponent<Transform>();
    }

    // Update is called once per frame
    public Animator selfevent;
    public Transform turn;
    public Rigidbody2D selfmove;
    public float walkspd;
    public bool barriertouch;
    public float runspeed;
    public bool eventtime=false;
    private Transform self;
    private Transform rockchair;
    private float timecount;
    void Update()
    {
      selfevent.SetFloat("speed",Mathf.Abs(selfmove.velocity.x));
      if (eventtime==false)
      {
        selfevent.SetLayerWeight(1,1);
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))&& (Input.GetKey(KeyCode.LeftShift)==false))
        {
        selfmove.velocity= new Vector2(Input.GetAxisRaw("Horizontal")*walkspd,selfmove.velocity.y);
        }
        else if ( (Input.GetKey(KeyCode.A)&&Input.GetKey(KeyCode.LeftShift)) || (Input.GetKey(KeyCode.D)&&Input.GetKey(KeyCode.LeftShift)) )
        {
          selfmove.velocity= new Vector2(Input.GetAxisRaw("Horizontal")*runspeed,selfmove.velocity.y);
        }  
        if (Input.GetKey(KeyCode.A))
        {
          turn.localScale= new Vector2(-Mathf.Abs(turn.localScale.x),turn.localScale.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
          turn.localScale= new Vector2(Mathf.Abs(turn.localScale.x),turn.localScale.y);
        }
      }
    }
  void OnCollisionEnter2D(Collision2D other)
  {
     if (other.gameObject.CompareTag("barrier"))
     {
      barriertouch=true;
     } 
     if (other.gameObject.name== "wife event")
     {
      eventtime=true;
     }
  }
  void OnCollisionExit2D(Collision2D other)
  {
      if (other.gameObject.CompareTag("barrier"))
      {
        barriertouch=false;
      }
  }
}
