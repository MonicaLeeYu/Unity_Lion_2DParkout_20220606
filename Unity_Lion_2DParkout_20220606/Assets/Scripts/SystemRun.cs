using UnityEngine; //引用unity引擎命名空間(API)

namespace MonicaLee
{
    /// <summary>
    /// 跑步程式
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region 資料:保存系統需要的資料
        /*欄位 Field : 保存方法 
         * private float speedRun = 3.5f;這樣一行就是一個欄位
         * 語法 : 修飾詞 欄位的資料類型 欄位自訂名稱(灰色) =指定 預設值);
         * 修飾詞 : 分為公開和私人
         * 公開public: 顯示在面板，允許其他類別存取
         * 私人private: 不顯示在面板，不允許其他類別存取(封裝)
         */
        //SerializeField序列化欄位:將私人欄位顯示在面板上

        [SerializeField, Header("跑步速度"), Tooltip("角色忍者龜的跑步速度"), Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("跳躍高度"), Tooltip("角色忍者龜的跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region 功能:實作該系統的複雜方法

        #endregion

        #region 事件:程式入口
        private void Start()
        {
            print("WELCOME TO MONICA GAME WORLD");
        }

        #endregion

    }
}

