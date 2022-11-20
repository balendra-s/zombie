using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    [SerializeField] private float lookSensitivity;
    [SerializeField] private float smoothing;
    [SerializeField] private int maxLookRotationAngel;
    public Vector2 smoothedVelocity;
    private GameObject player;
    private float cameraTotalRotation = 0;
    private float playerTotalRotation = 0;

    private void Start()
    {
        player = transform.parent.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void FixedUpdate()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        // rotate camera
        float _camRot = Input.GetAxisRaw("Mouse Y");
        float smoothedCamRot = _camRot * lookSensitivity * smoothing;
        smoothedCamRot = Mathf.Lerp(smoothedCamRot, _camRot, 1f / smoothing);
        cameraTotalRotation += smoothedCamRot;
        transform.localRotation = Quaternion.AngleAxis(-cameraTotalRotation, Vector3.right);

        // rotate player
        float playerRot = Input.GetAxisRaw("Mouse X");
        float smoothedPlayerRot = playerRot * lookSensitivity * smoothing;
        smoothedPlayerRot = Mathf.Lerp(smoothedPlayerRot, playerRot, 1f / smoothing);
        playerTotalRotation += smoothedPlayerRot;
        player.transform.localRotation = Quaternion.AngleAxis(playerTotalRotation, player.transform.up);
    }
}
