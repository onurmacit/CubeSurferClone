
using UnityEngine;

public class HeroInputController : MonoBehaviour
{
    private float horizantalValue;

    public float HorizontalValue
    {
        get { return horizantalValue; }
    }
   

    
    void Update()
    {
        HandleHorizontalInput();
    }



    private void HandleHorizontalInput()
    {
        if (Input.GetMouseButton(0))
        {
            horizantalValue = Input.GetAxis("Mouse X");
        }
        else
        {
            horizantalValue = 0;
        }
    }
}
