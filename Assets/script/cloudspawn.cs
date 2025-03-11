

using UnityEngine;

public class cloudspawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     self.position=new Vector3(playerpos.position.x+offsetx,playerpos.position.y+offsety,self.position.z);
    }
    private float timecount;
    public GameObject[] cloud;
    public Transform self;
    public float duration;
    public Transform playerpos;
    private float cloudonscreen=7;
    public string cl;
    public float offsetx;
    public float offsety;
    // Update is called once per frame
    void Update()
    {
      if (GameObject.FindGameObjectsWithTag(cl).Length<cloudonscreen)
      {
        if (timecount>=duration)
        {
         Instantiate(cloud[Random.Range(0,7)],self.position,self.rotation);
         duration=Random.Range(0,5);
         timecount=0;
         cloudonscreen=Random.Range(7,10);
        }
       timecount+=Time.deltaTime;
      }
      else 
      {
        timecount=0;
      }
      self.position=new Vector3(playerpos.position.x+offsetx,playerpos.position.y+offsety,self.position.z);
    }
}
