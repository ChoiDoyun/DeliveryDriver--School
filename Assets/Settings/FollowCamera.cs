using System.Collections;
using TMPro;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followTarget;

    //[SerializeField] private TMP_Text text;
    [SerializeField] private float time;
    [SerializeField] private float curTime;

    int minute;
    int second;

    private void Awake()
    {
        time = 70;
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        curTime = time;
        while (curTime > 0)
        {
            curTime -= Time.deltaTime;
            minute = (int)curTime / 60;
            second = (int)curTime % 60;
            //text.text = minute.ToString("00") + second.ToString("00");
            yield return null;

            if (curTime <= 0)
            {
                Debug.Log("시간종료");
                curTime = 0;
                yield break;
            }
        }

    }

    void LateUpdate()
    {
        transform.position = followTarget.transform.position + new Vector3(0, 0, -10);
    }

}
