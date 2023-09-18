using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody PlayerRigidBody;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
        playerInputActions = new PlayerInputActions();
    }
    private void FixedUpdate()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 10f;
        PlayerRigidBody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
    public void MovementMade(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        Vector2 inputVector = context.ReadValue<Vector2>();
        float speed = 10f;
        PlayerRigidBody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Hello " + context.phase);
            PlayerRigidBody.AddForce(Vector3.up * 30f, ForceMode.Impulse);
        }
    }
}
