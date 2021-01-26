using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ObjectSelector : MonoBehaviour
{
    private Transform ThisTransform = null;
    public LayerMask RayCastMask;
    public float SightDistance = 3f;
    public UnityEvent OnObjectFocusChange;

    public GameObject FocusObject
    {
        get { return _FocusObject; }
        set
        {
            if (_FocusObject == null && value == null) return;

            if (_FocusObject != null && value != null)
                    if (_FocusObject.GetInstanceID() == value.GetInstanceID()) return;

            if (_FocusObject != null)
                _FocusObject.GetComponent<InteractObject>().RemoveHighlight();

            if (value != null)
                value.GetComponent<InteractObject>().AddHighlight();

            _FocusObject = value;
            OnObjectFocusChange.Invoke();
        }
    }

    [SerializeField]
    private GameObject _FocusObject = null;

    private void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            if (FocusObject!=null)
            {
                FocusObject.SendMessage("Select", SendMessageOptions.DontRequireReceiver);
                return;
            }
        }

        RaycastHit HitInfo;
        if (Physics.Raycast(ThisTransform.position, ThisTransform.forward, out HitInfo, SightDistance, RayCastMask))
        {
            FocusObject = HitInfo.collider.gameObject;
            return;
        }

        FocusObject = null;
    }
}
