using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    
    private void Update()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
