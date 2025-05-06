
using TMPro;
using UnityEngine;

public class canonintroduce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    public GameObject textbox;
    public string content;
    void Update()
    {
        if(transform.position.x+3>player.transform.position.x&&transform.position.x-3<player.transform.position.x){
            GetComponent<SpriteRenderer>().enabled=true;
            if(Input.GetKeyDown(KeyCode.F)){
                if(textbox.activeSelf==false){
                    Debug.Log("ok");
                    textbox.SetActive(true);
                }
                else{
                    textbox.SetActive(false);
                }
            }
        }
        else{
            GetComponent<SpriteRenderer>().enabled=false;
        }   
    }
    
     
}
