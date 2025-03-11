
using UnityEngine;

public class grabRope : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        self=GetComponent<Transform>();
    }
    public Transform grabpath;
    private  Transform self;
    public float offsetx;
    public float offsety;
    public Transform bone;
    public float offsetrot;

    // Update is called once per frame
    void Update()
    {;
        self.position=new Vector2(grabpath.position.x+offsetx,grabpath.position.y+offsety);
        self.rotation=Quaternion.Euler(0,0,bone.eulerAngles.z+offsetrot);
    }
}
