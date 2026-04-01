using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public class PlayerControler : MonoBehaviour
{

    public InputYas clickerControl;
    public GameObject piano;
    private InputAction interact;
    private InputAction leftright;

    private void Awake()
    {
        clickerControl = new InputYas();
        
    }

    void Start()
    {

    }

    private void OnEnable()
    {
        interact = clickerControl.Player.Interact;
        interact.Enable();
        interact.performed += Interact;

        leftright = clickerControl.Player.Move;
        leftright.Enable();
       // leftright.performed += Move;
    }

    private void OnDisable()
    {
        interact.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveee = leftright.ReadValue<Vector2>();

        if( moveee != null)
        {
            Move(moveee);
        }

    }

    //private void Move(InputAction.CallbackContext context)
    private void Move(Vector2 moveee)
    {
      //  Debug.Log("Move");
        Vector3 newmove = new Vector3(-moveee.x/10, moveee.y/10, 0);

        Vector3 whereTo = piano.transform.position + newmove;

        whereTo.x = Mathf.Clamp(whereTo.x, -32, 10);

        whereTo.y = Mathf.Clamp(whereTo.y, -2, -2);

        piano.transform.position = whereTo;
    }

    private void Interact(InputAction.CallbackContext context)
    {
        Vector2 mousepo = Mouse.current.position.ReadValue(); 
        Vector2 worldPo = Camera.main.ScreenToWorldPoint(mousepo);

        RaycastHit2D hit = Physics2D.Raycast(worldPo, Vector2.zero);

        if (hit.collider != null)
        {
            Debug.Log("Hit: " + hit.collider.name);
            Playsound trigger = hit.collider.GetComponent<Playsound>();

            if (trigger != null)
            {
                trigger.SoundGo();
            }
        }
        //Input.mousePosition is wrong and outdated and doesn't work
        //Ray ray = new Ray(transform.position, Input.mousePosition);
    }
}
