
using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Rendering;

public class rockchairinteract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public GameObject player;
    public GameObject rockchair;
    public PlayableDirector sitdownscene;
    int first=1;
    public Vector3 chairpos;
    void Update()
    {
        if(transform.position.x+3>player.transform.position.x&&transform.position.x-3<player.transform.position.x){
            GetComponent<SpriteRenderer>().enabled=true;
            if(Input.GetKeyDown(KeyCode.F)){
                player.GetComponent<male1>().enabled=false;
                if(player.GetComponent<Animator>().GetBool("sit")==true){
                    standup();
                }
                else{
                    sitdown();
                }
            }
        }
        else{
            GetComponent<SpriteRenderer>().enabled=false;
        }
    }
    void sitdown(){
        player.GetComponent<Animator>().SetLayerWeight(2,1);
        player.GetComponent<Animator>().SetLayerWeight(1,0);
        player.GetComponent<Rigidbody2D>().velocity=new Vector3(0,0,0);
        player.transform.rotation=quaternion.Euler(0,0,0);
        player.transform.position=chairpos;
        if(first!=0){
            first=0;
            sitdownscene.Play();
        }
        player.GetComponent<Animator>().SetBool("sit",true);
        rockchair.GetComponent<SpriteRenderer>().sortingOrder=2;
    }
    void standup(){
        player.GetComponent<Animator>().SetBool("sit",false);
        StartCoroutine("standwait");
    }
    public IEnumerator standwait(){
        yield return new WaitForSeconds(1);
        player.GetComponent<Animator>().SetLayerWeight(2,0);
        player.GetComponent<Animator>().SetLayerWeight(1,1);
        player.GetComponent<male1>().enabled=true;
        rockchair.GetComponent<SpriteRenderer>().sortingOrder=10;
    }
}
