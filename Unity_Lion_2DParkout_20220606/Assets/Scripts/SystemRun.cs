using UnityEngine; //�ޥ�unity�����R�W�Ŷ�(API)

namespace MonicaLee
{
    /// <summary>
    /// �]�B�{��
    /// </summary>
    public class SystemRun : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����
        /*��� Field : �O�s��k 
         * private float speedRun = 3.5f;�o�ˤ@��N�O�@�����
         * �y�k : �׹��� ��쪺������� ���ۭq�W��(�Ǧ�) =���w �w�]��);
         * �׹��� : �������}�M�p�H
         * ���}public: ��ܦb���O�A���\��L���O�s��
         * �p�Hprivate: ����ܦb���O�A�����\��L���O�s��(�ʸ�)
         */
        //SerializeField�ǦC�����:�N�p�H�����ܦb���O�W

        [SerializeField, Header("�]�B�t��"), Tooltip("����Ԫ��t���]�B�t��"), Range(0,100)]
        private float speedRun = 3.5f;
        [SerializeField, Header("���D����"), Tooltip("����Ԫ��t�����D����"), Range(0, 3000)]
        private float heightJump = 350;
        private Animator ani;
        private Rigidbody2D rig;

        #endregion

        #region �\��:��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ�:�{���J�f
        private void Start()
        {
            print("WELCOME TO MONICA GAME WORLD");
        }

        #endregion

    }
}

