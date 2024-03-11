using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippingScript : MonoBehaviour
{

    public GameObject Slot1;
    public GameObject Slot2;
    public GameObject Slot3;
    public GameObject Slot4;
    public GameObject Slot5;
    public GameObject Slot6;
    public GameObject Slot7;
    public GameObject Slot8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Equip1();
        }

        if (Input.GetKeyDown("2"))
        {
            Equip2();
        }
        if (Input.GetKeyDown("3"))
        {
            Equip3();
        }
        if (Input.GetKeyDown("4"))
        {
            Equip4();

        }
        if (Input.GetKeyDown("5"))
        {
            Equip5();
        }
        if (Input.GetKeyDown("6"))
        {
            Equip6();
        }
        if (Input.GetKeyDown("7"))
        {
            Equip7();
        }
        if (Input.GetKeyDown("8"))
        {
            Equip8();
        }

    }

    void Equip1()
    {
        Slot1.SetActive(true);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
           Slot5.SetActive(false);
        Slot6.SetActive(false);
        Slot7.SetActive(false);
        Slot8.SetActive(false);

    }

    void Equip2()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(true);
        Slot3.SetActive(false);
        Slot4.SetActive(false) ;
        Slot5.SetActive(false);
            
        Slot6.SetActive(false);
        Slot7.SetActive(false);
            Slot8.SetActive(false);
    }
    void Equip3()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(true);
        Slot4.SetActive(false);
        Slot5.SetActive(false);

        Slot6.SetActive(false);
        Slot7.SetActive(false);
        Slot8.SetActive(false);
    }
    void Equip4()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(true);
        Slot5.SetActive(false);

        Slot6.SetActive(false);
        Slot7.SetActive(false);
        Slot8.SetActive(false);
    }
    void Equip5()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Slot5.SetActive(true);

        Slot6.SetActive(false);
        Slot7.SetActive(false);
        Slot8.SetActive(false);
    }
    void Equip6()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Slot5.SetActive(false);

        Slot6.SetActive(true);
        Slot7.SetActive(false);
        Slot8.SetActive(false);

    }
    void Equip7()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Slot5.SetActive(false);

        Slot6.SetActive(false);
        Slot7.SetActive(true);
        Slot8.SetActive(false);
    }
    void Equip8()
    {
        Slot1.SetActive(false);
        Slot2.SetActive(false);
        Slot3.SetActive(false);
        Slot4.SetActive(false);
        Slot5.SetActive(false);

        Slot6.SetActive(false);
        Slot7.SetActive(false);
        Slot8.SetActive(true);
    }
    


}