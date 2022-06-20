using UnityEngine; //引用unity引擎命名空間(API)

namespace MonicaLee
{
    /*C#從以下的藍圖變成實體物件，步驟如下
     * 1. 點選場景上的遊戲角色物件(Game Object灰色線條方塊)
     * 2. 在Inspector最下方點選Add Component將此C#腳本名稱SystemRun掛在該物件變成元件
     */
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

        /*[]中括號內放Attritube屬性，及註解等額外功能
         * SerializeField序列化欄位:將私人欄位顯示在面板上，可以增加註解標題、提示、範圍
         * Header標題 : 可以使用中文 ("跑步速度")
         * Tooltip提示 : 可以使用中文("角色忍者龜的跑步速度")
         * Range範圍 : 僅限數值類型資料(0,100)
         */
        [SerializeField, Header("跑步速度"), Tooltip("角色忍者龜的跑步速度"), Range(0, 100)]
        private float speedRun = 3.5f;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region 功能:實作該系統的複雜方法
        /// <summary>
        /// 跑步功能
        /// </summary>
        //方法Method, 習慣以大寫開頭命名
        //語法 : 修飾詞 傳回型態 方法名稱(參數){程式}
        private void Run()
        {
            print("跑步中~");
            //屬性.方法 velocity 指定 new一個二維座標
            rig.velocity = new Vector2(speedRun, rig.velocity.y); //()內可以直接給值，也可以給它屬性要調整直接在面板上調整即可
        }
        #endregion

        #region 事件:程式入口
        /* Awake一定要做在Start之前
         * 且在每次播放遊戲時會執行一次
         * 在Ani可以看到忍者龜(Animator)和Rig裡看到忍者龜(Rigidbody 2D)
         */
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();//也可以在屬性面板直接拉入
        }
        /* 開始事件: 播放遊戲時會執行一次
         * 初始化設定，例如:初始化生命值或初始化前幣值等等
         */
        private void Start()
        {
            //print("WELCOME TO MONICA GAME WORLD");//按play會在最下方的儀表板顯示
        }
        /* 把儀錶板Console拉到Inspector下方，顯示的訊息未來會常常需要參考
         * 更新事件:大約每秒執行60次 60FPS Frame per second
         */
        private void Update()
        {
            //print("<Color=yellow> 事件執行中並設定醒目顏色 </Color>");
            //呼叫方法的語法 : 方法名稱(對應的引數);
            Run();

        }

        #endregion

    }
}


