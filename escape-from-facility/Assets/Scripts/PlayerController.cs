using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Camera;
    
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float verticalSpeed;
    [SerializeField] private int normalSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        CameraMovement();
    }

    // This void is responsible for player movement in X and Z axis
    private void PlayerMovement()
    {
        // Set vertical and horizontal inputs
        verticalSpeed = Input.GetAxis("Vertical");
        horizontalSpeed = Input.GetAxis("Horizontal");
        
        // Move player in vertical Axis
        transform.Translate(Vector3.right * normalSpeed * verticalSpeed * Time.deltaTime);
        // Move player in horizontal Axis
        transform.Translate(Vector3.back * normalSpeed * horizontalSpeed * Time.deltaTime);
    }

    // This void is responsible for camera following the player
    private void CameraMovement()
    {
        Camera.transform.position = transform.position + new Vector3(0, 9, 0);
    }
}
