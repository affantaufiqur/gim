using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter = 15;
    public Text timerText;

    void Start()
    {
    	timerText.text = counter.ToString();
    	StartCoroutine(hitungmundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator hitungmundur(){
    	while(counter > 0){
    	yield return new WaitForSeconds(1);
    	counter -= 1;
    	timerText.text = counter.ToString();
		}

		//timerText.text = "GAME OVER!";
        SceneManager.LoadScene("GameOver");
    }
}
