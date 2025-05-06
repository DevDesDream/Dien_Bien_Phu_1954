using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;
[System.Serializable]
public class textboxinfor 
{
    public bool maindetect;
    public bool opponentdetect;
    public string line;
    public Sprite mainavt;
    public Sprite opponentavt;
}
[System.Serializable]
public class dialoguetext
{
    public List<textboxinfor> dialoguelines =new List<textboxinfor>();
} 
public class textbox:MonoBehaviour 
{
  public dialoguetext dialogue;
  public int num;
  public event Action main;
  public event Action maindisable;
  public event Action opponent;
  public event Action opponentdisable;
  public bool CutOrNot;
  public TextMeshProUGUI text;
  public PlayableDirector sitdownscene3;
  public GameObject nextscenedisable;
  
  void OnEnable(){
    nextscenedisable.SetActive(false);
  }
  void OnDisable(){
    nextscenedisable.SetActive(true);
  }
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Return))
    {
      num++;
    }
    if (CutOrNot==true)
    {
      if (num>=dialogue.dialoguelines.Count)
      {
        sitdownscene3.playableGraph.GetRootPlayable(0).SetSpeed(1);
        return;
      }
      else {
        sitdownscene3.playableGraph.GetRootPlayable(0).SetSpeed(0);
      }
    }
   if (num<dialogue.dialoguelines.Count)
    {
      if (dialogue.dialoguelines[num].maindetect==true)
      {
        main?.Invoke();
      }
      else{
        maindisable?.Invoke();
      }
      if (dialogue.dialoguelines[num].opponentdetect==true)
      {
        opponent?.Invoke();
      }
      else{
        opponentdisable?.Invoke();
      }
      text.text=dialogue.dialoguelines[num].line;
    }
  }
}
