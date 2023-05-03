using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParslegsana : MonoBehaviour {
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject garumaSlaideris;

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        else if (skaitlis == 1)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        else if (skaitlis == 2)
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[2];
        Debug.Log("Nav piesaistīts attēls!");
    }

    



}
