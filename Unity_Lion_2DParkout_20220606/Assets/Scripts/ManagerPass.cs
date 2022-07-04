
using UnityEngine;

namespace MonicaLee
{
    /// <summary>
    /// 終點過關管理
    /// </summary>
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("目標名稱")]
        private string nameTarget = "忍者龜";
        [SerializeField, Header("跑步系統")]
        private SystemRun systemRun;
        [SerializeField, Header("跳躍系統")]
        private SystemJump systemJump;
        [SerializeField, Header("結束畫布管理器")]
        private ManageFinal manageFinal;



        #region 其中一個物件有勾選 Is trigger
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name); //測試完關閉
            //如果碰撞物件名稱 包含 (忍者龜) //字串都可以使用 包含Contains()
            if (collision.name.Contains(nameTarget))
            {
                systemJump.enabled = false;
                systemRun.enabled = false;
                manageFinal.enabled = true;
                manageFinal.stringTitle = "~恭喜你過關~";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion
        #region 兩個物件都沒有勾選 Is trigger
        private void OnCollisionEnter2D(Collision2D collision)
        {
            
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
        #endregion
    }
}

