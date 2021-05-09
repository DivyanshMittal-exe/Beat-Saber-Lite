using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    
    public static bool GamePause = false;
    public GameObject PauseMenuUI;
    public AudioSource audioSourceG;
    public AudioSource audioSourceP;



    void Start()
    {
    
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GamePause){
                resume();
            }else{
                pause();
            }
        }
    }
    void pause(){
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
        audioSourceG.Pause();
        audioSourceP.Play(0);
    }
    void resume(){
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
        audioSourceG.Play();
        audioSourceP.Pause();
    }

    public void MainMeuPause(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void VolumeisSet(float vol){
       audioMixer.SetFloat("VolumePara",vol);
    }
}
