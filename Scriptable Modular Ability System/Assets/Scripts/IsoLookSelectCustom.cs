using UnityEngine;

public class IsoLookSelectCustom : MonoBehaviour
{
    public LayerMask groundLayer;
    public LayerMask selectableLayer;

    public GameObject selectedObject;
    public GameObject highlightedObject;

    public Vector3 mouseLocation;
    public Camera mainCamera;

    RaycastHit hitData;
    Ray ray;


    void Start()
    {

    }


    void Update()
    {
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hitData, 1000, groundLayer))
        {
            RotatePlayer();
        }

        if (Physics.Raycast(ray, out hitData, 1000, selectableLayer))
        {
            RotatePlayer();

            highlightedObject = hitData.transform.gameObject;

            if (Input.GetMouseButtonDown(0))
            {
                selectedObject = hitData.transform.gameObject;

            }
        }
        else
        {

            highlightedObject = null;

            if (Input.GetMouseButtonDown(0))
            {
                selectedObject = null;
            }
        }
    }

    void RotatePlayer()
    {
        mouseLocation = hitData.point;
        transform.LookAt(new Vector3(mouseLocation.x, transform.position.y, mouseLocation.z));
    }

}
