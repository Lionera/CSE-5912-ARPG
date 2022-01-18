using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueUI : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //textLabel.text = "Hello there!";
        GetComponent<TypeWriterEffect>().Run(textToType:"Hello there!", textLabel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private TMP_Text textLabel;


}
