using UnityEngine;

public class IgrokControl : MonoBehaviour
{
    public float speed = 4f;
    public Transform cameraTransform;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(movement, Space.Self);

        if (cameraTransform != null)
        {
            cameraTransform.position = transform.position + new Vector3(0, 2, -5);
        }
    }
}
