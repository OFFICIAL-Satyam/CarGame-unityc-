using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
   [SerializeField] Color32 hasPackagecolor = new Color32(1,1,1,1);
   [SerializeField] Color32 noPackagecolor = new Color32(1,1,1,1);

   [SerializeField] float destroyDelay = 0.5f;

   bool hasPackage ;

   SpriteRenderer spriteRenderer;

   void Start() 
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      
   }
   
   void OnCollisionEnter2D(Collision2D other) 
   {
    Debug.Log("Ouch!!");
   }
   void OnTriggerEnter2D(Collider2D other) 
   {
    if ( other.tag == "Package" && hasPackage == false )
    {
      Debug.Log("Package Picked Up");
      hasPackage = true;
      spriteRenderer.color = hasPackagecolor;

      Destroy(other.gameObject,destroyDelay);
    }
    if (other.tag == "Customer" && hasPackage )
    {
      Debug.Log("Package Delivered");
      hasPackage = false;
      spriteRenderer.color = noPackagecolor;
    }
   }
}
