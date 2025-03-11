
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class canonwarning : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void turnoff(){
        disab.enabled=false;
        foreach (GameObject hi in but){
            hi.GetComponent<SpriteRenderer>().enabled=false;
             hi.GetComponent<butaction>().enabled=false;
        }
        foreach (Animator anim in activate){
            anim.SetBool("canonwarning",true);
        }
        foreach (GameObject canon in Canon){
            canon.GetComponent<pullcanon>().enabled=false;
            canon.GetComponent<Rigidbody2D>().drag=500;
        }
        timecd.SetActive(false);
        foreach(Animator ani in stopchenphao){
        ani.SetFloat("phase",1);
        }
    }
    public GameObject timecd;
    public Animator[] activate; 
    public GameObject[] Canon;
    public GameObject[] grab;
    public GameObject[] but;
    //live and time
    public GameObject[] livecount;
    public float time;
    private float cd=0;
    public int live=3;
    public int timelimit;
    //
    public startclimb disab;
    private int spacecount=0;
    private bool fallL=false;
    public GameObject heart;
    public GameObject space;
   
    public Animator[] stopchenphao;
    public PlayableDirector fall;
    public Rigidbody2D self;

    void Update()
    {
        if (live>=0){
        livecount[live].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            spacecount++;
        }
        time+=Time.deltaTime;
        if (time>timelimit){
                time=0;
                if (spacecount>10){
                    active();
                }
                else{
                    disable();
                    fallL=true;
                }
            }
        if (live<1){
            disable();
            fallL=true;
            
        }
        if (fallL==true){
            cd+=Time.deltaTime;
            if (cd>3.5){
             SceneManager.LoadScene("scene 4");
            }
        }
     }
    public void disable(){
        heart.SetActive(false);
        space.SetActive(false);
        self.gravityScale=2;
         foreach(Animator ani in stopchenphao){
        ani.SetFloat("phase",2);
        }
        foreach (Animator anim in activate){
                            anim.SetBool("falldown",true);
                        }
          foreach (GameObject obj in grab){
                  obj.GetComponent<grabRope>().enabled=false;
                  obj.GetComponent<BoxCollider2D>().enabled=true;
                  obj.GetComponent<Rigidbody2D>().bodyType=RigidbodyType2D.Dynamic;
                }
               fall.enabled=true;
        Canon[0].GetComponent<Rigidbody2D>().drag=0;
        Canon[1].GetComponent<Rigidbody2D>().constraints=RigidbodyConstraints2D.FreezePosition;
    }
    public void active(){
        space.SetActive(false);
                heart.SetActive(false);
                spacecount=0;
         foreach(Animator ani in stopchenphao){
               ani.SetFloat("phase",0);
         }
                foreach (GameObject canon in Canon){
                canon.GetComponent<pullcanon>().enabled=true;
                canon.GetComponent<Rigidbody2D>().drag=0;
                }
                foreach (Animator anim in activate){
                anim.SetBool("canonwarning",false);
                }
                foreach (GameObject hi in but){
                hi.GetComponent<SpriteRenderer>().enabled=true;
                hi.GetComponent<butaction>().enabled=true;
                }
                timecd.SetActive(true);
                timecd.GetComponent<timecd>().setup();
    }
}
