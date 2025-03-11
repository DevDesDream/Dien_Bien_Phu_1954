
using System;
using UnityEngine;


public class male1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        selfevent=GetComponent<Animator>();
        self=GetComponent<Transform>();
       rockchair=GameObject.Find("chair for main").transform;
       canon=GameObject.Find("canon").transform;
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
    public event Action sitdown;
    public event Action standup;
    public event Action disable;
    public event Action canoninterract;
    private Transform canon;
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
      //sitdown event
      if ((self.position.x<rockchair.position.x+2)&&(self.position.x>rockchair.position.x-1))
      {
        
       if (Input.GetKeyDown(KeyCode.S))
        {
          selfevent.SetBool("sit stand",true);
          eventtime=true;
          selfevent.SetLayerWeight(2,1);
          selfevent.SetLayerWeight(1,0);
          self.position= new Vector2(rockchair.position.x+1.8f,self.position.y);
          selfmove.velocity=new Vector2(0,0);
          self.localScale=new Vector2(0.4f,0.4f);
          standup?.Invoke();
        }
       if (Input.GetKeyDown(KeyCode.W))
        {
          selfevent.SetBool("sit stand",false);
          timecount=Time.time;
        }
        if (selfevent.GetBool("sit stand")==false)
        {
          if (Time.time-timecount>1.2)
          {
          sitdown?.Invoke();
          }
          if (Time.time-timecount>1.5)
          {
          selfevent.SetLayerWeight(2,0);
          eventtime=false;
          }
        }
      }
      else {
        disable?.Invoke();
      }
      //canon touch
      if (self.position.x>canon.position.x-10)
      {
        canoninterract?.Invoke();
        if (Input.GetKeyDown(KeyCode.F))
        {
        canonintroduce.SetActive(true);
        eventtime=true;
        }
        
      }
      else if ((self.position.x<rockchair.position.x+2==false)&&(self.position.x>rockchair.position.x-1==false)){
        disable?.Invoke();
      }
    }
    public GameObject canonintroduce;


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
