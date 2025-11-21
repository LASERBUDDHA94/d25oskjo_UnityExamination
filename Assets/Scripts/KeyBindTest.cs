using UnityEngine;
using UnityEngine.InputSystem;

public class KeyBindTest : MonoBehaviour
{
    public InputActionAsset oskarsPlayerAction;
    public Animator oskarsAnimator;

    // Update is called once per frame
    void Update()
    {
        if (oskarsPlayerAction.FindAction("TestAction").IsPressed())
            {
            oskarsAnimator.SetBool("Running", true);
            }
        else
            {
            oskarsAnimator.SetBool("Running", false);
            }
    }
}
