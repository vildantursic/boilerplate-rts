using System;
using UnityEngine;

public class ClickSelectController : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    public static event Action<PlayerUnit> OnSelectedEntityChanged;
    public static PlayerUnit SelectedEntity { get; private set; }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, 1f);

            if (Physics.Raycast(ray, out var hitInfo))
            {

                // TODO check logic for highlighting selected object
                var entity = hitInfo.collider.GetComponent<PlayerUnit>();
                if (entity != null) {
                    if (SelectedEntity != null) {
                        if (SelectedEntity != entity) {
                            SelectedEntity.SlectEntity(false);
                        }
                    }
                    SelectedEntity = entity;
                    SelectedEntity.SlectEntity(true);
                    OnSelectedEntityChanged?.Invoke(entity);
                } else {
                    if (SelectedEntity != null) {
                        SelectedEntity.SlectEntity(false);
                        entity = null;
                        SelectedEntity = entity;
                        OnSelectedEntityChanged?.Invoke(entity);
                    }
                }
            }
        }
    }
}
