using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKontroller : MonoBehaviour
{
    public static InputKontroller instance;
    private void Awake()
    {
        instance = this;
    }

    void Update()
    {

        farkkontrol();

    }


    Vector3 Giris;
    Vector3 fark;
    int esik = 30;
    //public playerkontrol player;

    public void farkkontrol()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Giris = Input.mousePosition;

        }

        if (Input.GetMouseButton(0))
        {
            fark = Input.mousePosition - Giris;

            if (Mathf.Abs(fark.x) > Mathf.Abs(fark.y))
            {
                if (Mathf.Abs(fark.x) > esik)
                {
                    if (fark.x > 0)
                    {
                        PlayerKontroller.instance.gitme(PlayerKontroller.yon.sag);
                        Giris = Input.mousePosition;
                    }
                    else
                    {
                        PlayerKontroller.instance.gitme(PlayerKontroller.yon.sol);
                        Giris = Input.mousePosition;
                    }
                }

            }
            else
            {
                if (Mathf.Abs(fark.y) > esik)
                {
                    if (fark.y > 0)
                    {
                        PlayerKontroller.instance.gitme(PlayerKontroller.yon.yukari);
                        Giris = Input.mousePosition;
                    }
                    else
                    {
                        PlayerKontroller.instance.gitme(PlayerKontroller.yon.asagi);
                        Giris = Input.mousePosition;


                    }
                }
            }
        }


    }
}
