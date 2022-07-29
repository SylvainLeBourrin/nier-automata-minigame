using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMe : MonoBehaviour
{
    public GameObject Shooter;
    private Vector2 moveZ = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            for (var projectil = 0; projectil < 1; projectil++)
            {

                Object.Instantiate(Shooter);
               // moveZ = new Vector2(1.0);

            }
            //Definir si shooter est appeler une direction unique 
           // Shooter.Move(moveZ * Time.deltaTime);




        }
    }
}
