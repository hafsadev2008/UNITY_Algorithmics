using System .collection;
using System.Collections.Genertic;
using UnityEnging;

public class Button; MonoBehaviour
{
    public Animator button;
    public Animator toOpen;
    
    void Start()
 {
      button.enabled = false;
  }
  private void OnTriggerEnter(Collider other)
  {
      button.enabled = true;
      toOpen.enabled = true;
   }
}
