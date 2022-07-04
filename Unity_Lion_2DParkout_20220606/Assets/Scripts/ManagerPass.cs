
using UnityEngine;

namespace MonicaLee
{
    /// <summary>
    /// ���I�L���޲z
    /// </summary>
    public class ManagerPass : MonoBehaviour
    {
        [SerializeField, Header("�ؼЦW��")]
        private string nameTarget = "�Ԫ��t";
        [SerializeField, Header("�]�B�t��")]
        private SystemRun systemRun;
        [SerializeField, Header("���D�t��")]
        private SystemJump systemJump;
        [SerializeField, Header("�����e���޲z��")]
        private ManageFinal manageFinal;



        #region �䤤�@�Ӫ��󦳤Ŀ� Is trigger
        private void OnTriggerEnter2D(Collider2D collision)
        {
            //print(collision.name); //���է�����
            //�p�G�I������W�� �]�t (�Ԫ��t) //�r�곣�i�H�ϥ� �]�tContains()
            if (collision.name.Contains(nameTarget))
            {
                systemJump.enabled = false;
                systemRun.enabled = false;
                manageFinal.enabled = true;
                manageFinal.stringTitle = "~���ߧA�L��~";
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            
        }
        #endregion
        #region ��Ӫ��󳣨S���Ŀ� Is trigger
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

