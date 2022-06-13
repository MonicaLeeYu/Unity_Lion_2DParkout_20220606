using UnityEngine;

namespace MonicaLeeAPIStatic
{
    public class APIStatic : MonoBehaviour
    {
        private void Start()
        {
            #region 課堂練習
            //get
            print("隨機值= "+ Random.value);
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
            print("allcamerascount = " + allcamerascount);
            print("應用程式的平台" + Application.platform);

        }
        private void Update()
        {
            #region 課堂練習
            int rangeInt = Random.Range(1, 3);
            print("RandomRangeInt = " + rangeInt);
            #endregion
        }
    }
}


