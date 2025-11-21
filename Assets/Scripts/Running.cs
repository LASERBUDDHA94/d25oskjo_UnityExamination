using UnityEngine;
using UnityEngine.InputSystem;

public class Running : MonoBehaviour
{

    public InputActionAsset oskarsPlayerAction;
    public Animator oskarsAnimator;
    
    void Update()
    {
        if (oskarsPlayerAction.FindAction("Move").IsPressed())
            {
            oskarsAnimator.SetBool("IsRunning", true);
            }
        else
        {
            oskarsAnimator.SetBool("IsRunning", false);
        }
    }
}
