using UnityEngine;

namespace MonicaLeeAPIStatic
{
    public class APIStatic : MonoBehaviour
    {
        private Vector3 a = new Vector3(1, 1, 1);
        private Vector3 b = new Vector3(22, 22, 22);

        private void Start()
        {
            #region 課堂練習
            //get
            print("隨機值= " + Random.value);
            print("取得PI = " + Mathf.PI);
            print("取得無限大 = " + Mathf.Infinity);


            //set
            Cursor.visible = false;
            Physics2D.gravity = new Vector2(0.9f, -1.0f);
            Time.timeScale = 0.8f;

            float range = Random.Range(20.5f, 100.0f);
            print("RandomRange = " + range);

            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion


            int allcamerascount = Camera.allCamerasCount;
            print("所有攝影機 = " + allcamerascount);
            print("應用程式的平台 = " + Application.platform);

            print("物理睡眠臨界值設定為 = " + Physics.sleepThreshold);

            Time.timeScale = 0.8f;
            print("時間大小設定為 0.8 (慢動作) = " + Time.timeScale);
            Mathf.Round(9.999f);
            print("對9.999去小數點(四捨五入) = " + Mathf.Round(9.999f));
            Mathf.Ceil(9.999f);
            print("對9.999去小數點(無條件進位) = " + Mathf.Ceil(9.999f));
            Mathf.Floor(9.999f);
            print("對9.999去小數點(無條件捨去) = " + Mathf.Floor(9.999f));

            float dist = Vector3.Distance(a, b);
            print("<color=red>取得兩點的距離 = " + dist + "</color>");

            Application.OpenURL("https://unity.com/"); //開啟連結網址

        }
        private void Update()
        {
            #region 課堂練習
            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion
            //print("是否輸入任意鍵 = " + Input.anyKeyDown);
            //print("遊戲經過時間 = " + Time.timeSinceLevelLoad);
            print("<color=lightblue>是否按下按鍵(指定為空白鍵) = " + Input.GetKeyDown(KeyCode.Space) + "</color>");
        }
    }
}


