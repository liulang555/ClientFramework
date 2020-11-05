using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MyTrain : MonoBehaviour
{

    public Transform effectTrans;
    public Transform trackTrans;
    public Transform curveTrackTrans;

    List<Transform> selectPosList;
    private void Awake()
    {
        selectPosList = new List<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction, Color.red);
        if (Input.GetMouseButton(0))
        {
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.DrawRay(ray.origin, ray.direction, Color.red);
            RaycastHit[] hit = Physics.RaycastAll(ray, Mathf.Infinity, 1 << LayerMask.NameToLayer("block"));
            if (hit.Length > 0)
            {
                for (int i = 0; i < hit.Length; i++)
                {
                    if (hit[i].collider.transform.name.Contains("dikuai"))
                    {
                        var targetTrans = hit[i].collider.transform;
                        var selectPos = targetTrans.position;
                        if (!selectPosList.Contains(targetTrans))
                        {
                            if (selectPosList.Count > 0)
                            {
                                var prePos = selectPosList[selectPosList.Count - 1].localPosition;
                                var curPos = targetTrans.localPosition;
                                if (prePos.x != curPos.x && prePos.z != curPos.z)
                                {
                                    return;
                                }
                            }
                            var effectTransItem = GameObject.Instantiate(effectTrans, targetTrans);
                            effectTransItem.gameObject.SetActive(true);
                            effectTransItem.localPosition = new Vector3(0, 1, 0);
                            selectPosList.Add(targetTrans);
                        }
                    }
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            for (int i = 0; i < selectPosList.Count; i++)
            {
                Debug.LogError(selectPosList[i].localPosition);
                Vector3 localRotation = Vector3.zero;
                int type = 1;
                if (i > 0 && selectPosList.Count > i + 1)
                {
                    var preLocalPos = selectPosList[i - 1].localPosition;
                    var curLocalPos = selectPosList[i].localPosition;
                    var nextLocalPos = selectPosList[i + 1].localPosition;
                    if (curLocalPos.x == preLocalPos.x && curLocalPos.z > preLocalPos.z && curLocalPos.x < nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                    {
                        type = 2;
                        localRotation.y = 180;
                    }
                    else if (curLocalPos.x > preLocalPos.x && curLocalPos.z == preLocalPos.z && curLocalPos.x == nextLocalPos.x && curLocalPos.z > nextLocalPos.z)
                    {
                        type = 2;
                        localRotation.y = 270;
                    }
                    else if (curLocalPos.x == preLocalPos.x && curLocalPos.z < preLocalPos.z && curLocalPos.x > nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                    {
                        type = 2;
                        localRotation.y = 0;
                    }
                    else if (curLocalPos.x < preLocalPos.x && curLocalPos.z == preLocalPos.z && curLocalPos.x == nextLocalPos.x && curLocalPos.z < nextLocalPos.z)
                    {
                        type = 2;
                        localRotation.y = 90;
                    }
                    if (type == 1)
                    {
                        preLocalPos = selectPosList[i + 1].localPosition;
                        curLocalPos = selectPosList[i].localPosition;
                        nextLocalPos = selectPosList[i - 1].localPosition;
                        if (curLocalPos.x == preLocalPos.x && curLocalPos.z > preLocalPos.z && curLocalPos.x < nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                        {
                            type = 2;
                            localRotation.y = 180;
                        }
                        else if (curLocalPos.x > preLocalPos.x && curLocalPos.z == preLocalPos.z && curLocalPos.x == nextLocalPos.x && curLocalPos.z > nextLocalPos.z)
                        {
                            type = 2;
                            localRotation.y = 270;
                        }
                        else if (curLocalPos.x == preLocalPos.x && curLocalPos.z < preLocalPos.z && curLocalPos.x > nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                        {
                            type = 2;
                            localRotation.y = 0;
                        }
                        else if (curLocalPos.x < preLocalPos.x && curLocalPos.z == preLocalPos.z && curLocalPos.x == nextLocalPos.x && curLocalPos.z < nextLocalPos.z)
                        {
                            type = 2;
                            localRotation.y = 90;
                        }
                    }

                    if (type == 1 && selectPosList.Count > i + 1)
                    {
                        if (curLocalPos.x == nextLocalPos.x && curLocalPos.z < nextLocalPos.z)
                        {
                            localRotation.y = 0;
                        }
                        else if (curLocalPos.x < nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                        {
                            localRotation.y = 90;
                        }
                        else if (curLocalPos.x == nextLocalPos.x && curLocalPos.z > nextLocalPos.z)
                        {
                            localRotation.y = 0;
                        }
                        else if (curLocalPos.x > nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                        {
                            localRotation.y = 90;
                        }
                        type = 1;
                    }
                }
                else if (selectPosList.Count == i + 1)
                {
                    var preLocalPos = selectPosList[i - 1].localPosition;
                    var curLocalPos = selectPosList[i].localPosition;
                    if (curLocalPos.x == preLocalPos.x && curLocalPos.z < preLocalPos.z)
                    {
                        localRotation.y = 0;
                    }
                    else if (curLocalPos.x < preLocalPos.x && curLocalPos.z == preLocalPos.z)
                    {
                        localRotation.y = 90;
                    }
                    else if (curLocalPos.x == preLocalPos.x && curLocalPos.z > preLocalPos.z)
                    {
                        localRotation.y = 0;
                    }
                    else if (curLocalPos.x > preLocalPos.x && curLocalPos.z == preLocalPos.z)
                    {
                        localRotation.y = 90;
                    }
                    type = 1;
                }
                else if (selectPosList.Count > i + 1)
                {
                    var curLocalPos = selectPosList[i].localPosition;
                    var nextLocalPos = selectPosList[i + 1].localPosition;
                    if (curLocalPos.x == nextLocalPos.x && curLocalPos.z < nextLocalPos.z)
                    {
                        localRotation.y = 0;
                    }
                    else if (curLocalPos.x < nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                    {
                        localRotation.y = 90;
                    }
                    else if (curLocalPos.x == nextLocalPos.x && curLocalPos.z > nextLocalPos.z)
                    {
                        localRotation.y = 0;
                    }
                    else if (curLocalPos.x > nextLocalPos.x && curLocalPos.z == nextLocalPos.z)
                    {
                        localRotation.y = 90;
                    }
                    type = 1;
                }

                if (type == 1)
                {
                    var trackTransItem = GameObject.Instantiate(trackTrans, selectPosList[i]);
                    trackTransItem.localPosition = new Vector3(0, 200, 0);
                    trackTransItem.localEulerAngles = localRotation;
                    trackTransItem.DOLocalMove(new Vector3(0, 5, 0), 0.2f).SetDelay(i * 0.1f).OnPlay(()=> {
                        trackTransItem.gameObject.SetActive(true);
                    });
                }
                else if (type == 2)
                {
                    var trackTransItem = GameObject.Instantiate(curveTrackTrans, selectPosList[i]);
                    trackTransItem.gameObject.SetActive(true);
                    trackTransItem.localPosition = new Vector3(0, 200, 0);
                    trackTransItem.localEulerAngles = localRotation;
                    trackTransItem.DOLocalMove(new Vector3(0, 5, 0), 0.2f).SetDelay(i * 0.1f).OnPlay(()=> {
                        trackTransItem.gameObject.SetActive(true);
                    });
                }
            }
            selectPosList.Clear();
        }
    }
}
