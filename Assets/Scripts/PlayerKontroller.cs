using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerKontroller : MonoBehaviour
{
    public static PlayerKontroller instance;
    
    

    private void Awake()
    {
        instance = this;
    }

    //yön tanýmlamalarý
    public enum yon
    {
        sag, sol, yukari, asagi
    }
    //[SerializeField] private List<Transform> hedef;

    // public Transform hedef1;

    void Start()
    {
       // _ilkpozisyon = gameObject.transform.position;
    }
    /*
    Vector3 _ilkpozisyon;

    public void ilk_pozisyon()
    {
        gameObject.transform.position = new Vector3(_ilkpozisyon.x, _ilkpozisyon.y,_ilkpozisyon.z); 
    }
    */


    // Yönlerin Konrolü harekete baðlý.
    public void gitme(yon yon)
    {
        if (hareketkontrol)
            return;

        hareketkontrol = true;
        switch (yon)
        {
            case yon.sag:
                yonkotrol = new Vector3(1, 0, 0);
                break;
            case yon.sol:
                yonkotrol = new Vector3(-1, 0, 0);
                break;
            case yon.yukari:
                yonkotrol = new Vector3(0, 0, 1);
                break;
            case yon.asagi:
                yonkotrol = new Vector3(0, 0, -1);
                break;
            default: break;
        }
        kontrol = true;
    }

    //hareket tamamlandýktan sonra 
    void MovementCommpleted()
    {
        hareketkontrol = false;
    }

    [SerializeField] LayerMask Path;
    RaycastHit path;
   
   
    //dotween ile gidilecek yer
    void GoToDest(Vector3 dest)
    {
        transform.DOMove(dest, 0.5f).SetEase(Ease.InOutSine).OnComplete(MovementCommpleted);
    }

    bool hareketkontrol;
    bool kontrol;
    Vector3 yonkotrol;
  
    

    

    void Update()
    {
        

        if (kontrol)
        {
           
            //Raycast layerý olan objeyi görüyor ama tagg i path olana gidiyor

            if (Physics.Raycast(transform.position, yonkotrol, out path, 5000f,Path))
            {
                if (path.transform.gameObject.tag=="path")
                {
                    GoToDest(path.transform.position);
                }
                else
                {
                    hareketkontrol = false;
                }

            }

            else
            {
                hareketkontrol = false;
            }

            kontrol = false;
        }


    }
    /*
    public GameObject level1;
    public GameObject level2;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="finaly")
        {
            Destroy(level1);
            level2.SetActive(true);
        }
    }
    */
}
