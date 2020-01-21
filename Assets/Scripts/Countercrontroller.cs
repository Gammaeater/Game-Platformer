using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countercrontroller : MonoBehaviour

{
    int numbersofbox;
    Text counterView;

    // Start is called before the first frame update
    void Start()
    {

        ResetCounter();
    }
    public void Incrementcreat()
    {
        numbersofbox++;
        counterView.text = numbersofbox.ToString();

    }

    public void ResetCounter()
    {
        numbersofbox = 0;
        counterView.text = numbersofbox.ToString();
    }
}


