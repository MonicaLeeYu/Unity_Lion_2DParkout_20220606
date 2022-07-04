//using System.Collections;//這行沒用到，可以DELETE掉
//using System.Collections.Generic;//這行沒用到，可以DELETE掉
using UnityEngine;
namespace MonicaLee
{
    /// <summary>
    /// 跳躍功能
    /// </summary>
    //要注意MonoBehaviour要呈現綠色，
    //若非綠色則需到Unity\Edit\Preferences\External Tools\改選Script Editor2019
    public class SystemJump : MonoBehaviour
    {
        #region 資料:保存系統需要的資料
        /*欄位 Field : 保存方法 
         * 語法 : 修飾詞 欄位的資料類型 欄位自訂名稱(灰色) =指定 預設值);
         * 修飾詞 : 分為公開和私人
         * 公開public: 顯示在面板，允許其他類別存取
         * 私人private: 不顯示在面板，不允許其他類別存取(封裝)
         */

        /*[]中括號內放Attritube屬性，及註解等額外功能
         * SerializeField序列化欄位:將私人欄位顯示在面板上，可以增加註解標題、提示、範圍
         * Header標題 : 可以使用中文 ("跳躍高度")
         * Tooltip提示 : 可以使用中文("角色忍者龜的跳躍高度")
         * Range範圍 : 僅限數值類型資料(0,3000)
         * 以下這些private的修飾子無法在normal模式下被看見，可以切換到debug模式下檢視
         */
        [SerializeField, Header("跳躍高度"), Tooltip("角色忍者龜的跳躍高度"), Range(0, 3000)]
        private float heightJump = 350;
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundOffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1, 0, 0.2f, 0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;
        //[SerializeField]
        private Animator ani; //動畫的控制器，一個角色身上通常只會有一個
        //[SerializeField]
        private Rigidbody2D rig; //2D鋼體:設定運動行為如移動、旋轉和碰撞
        //[SerializeField]
        private bool clickJump; // 觸發跳躍
        private bool isGround; // 碰到地板

        #endregion

        #region 功能:實作該系統的複雜方法
        /// <summary>
        /// 跳躍功能
        /// </summary>
        //方法Method, 習慣以大寫開頭命名
        //語法 : 修飾詞 傳回型態 方法名稱(參數){程式}
        private void JumpKey()
        {
            //屬性.方法, 只要是鍵盤或滑鼠的輸入都是Input的屬性
            //如果 玩家 按下 空白鍵 就往上 跳躍
            //if 和 switch都是C#的判斷式
            //if 語法 : if (布林值){當布林值為TRUE時所要執行的程式}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //print("跳躍中~");
                clickJump = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void JumpForce()
        {
            //如果 玩家 按下 空白鍵 就產生一個往上的推力 && 碰到地板
            //if 和 switch都是C#的判斷式
            //if 語法 : if (布林值){當布林值為TRUE時所要執行的程式}
            if (clickJump && isGround)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false; //按一下就跳一次就好
            }
           
        }
        private void CheckGround()
        {
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundOffset, v3CheckGroundSize, 0, layerCheckGround);
            //print("碰到的物件 : " + hit.name); //測試觀察用，測完要註記掉
            isGround = hit;
        }

        #endregion

        #region 事件:程式入口
        /* Awake一定要做在Start之前
         * 且在每次播放遊戲時會執行一次
         * 在Ani可以看到忍者龜(Animator)和Rig裡看到忍者龜(Rigidbody 2D)
         */

        //繪製圖示
        //在編輯器內繪製輔助用的線條、形狀、圖片:遊戲內不會出現
        private void OnDrawGizmos() //打"ODG"就會出來按enter
        {
            Gizmos.color = colorCheckGround; //決定顏色
            Gizmos.DrawCube(transform.position + v3CheckGroundOffset, v3CheckGroundSize);//繪製圖示
            //transform.position+當前的物件座標
        }
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
            //Input API建議，Input這個屬性要寫在Update裡面
            //呼叫方法的語法 : 方法名稱(對應的引數);
            JumpKey();
            CheckGround();
        }

        //跟Update不一樣，固定每秒執行50次 50FPS Frame per second
        private void FixedUpdate()
        {
            JumpForce();
        }



        #endregion

    }
}



