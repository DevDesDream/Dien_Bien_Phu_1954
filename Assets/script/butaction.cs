

using UnityEngine;


public class butaction : MonoBehaviour
{
    void Start(){
        self=GetComponent<SpriteRenderer>();
        dis.enabled =false;
    }
    public Sprite[] aswd;
    private SpriteRenderer self;
    public startclimb dis;
    public Color[] change;
    public int currenturn;
    public canonwarning canon;
    public bool ok;
    public GameObject[] but;
    
    void Update()
    {
        if (ok==true){
           KeyCode[] key={KeyCode.A,KeyCode.D,KeyCode.S,KeyCode.W};
           for (int i=0;i<key.Length;i++){
               if (self.sprite==aswd[i]&&Input.GetKeyDown(key[i])){
                self.color=change[0];
                if (currenturn<3){
                 but[currenturn+1].GetComponent<butaction>().enabled=true;
                }
                break;
               }
           }
        }
        ok=!(Input.GetKeyDown(KeyCode.A)!=false&&Input.GetKeyDown(KeyCode.S)!=false&&Input.GetKeyDown(KeyCode.W)!=false&&Input.GetKeyDown(KeyCode.D)!=false);
    }

}

