//using System.Collections;//�o��S�Ψ�A�i�HDELETE��
//using System.Collections.Generic;//�o��S�Ψ�A�i�HDELETE��
using UnityEngine;
namespace MonicaLee
{
    /// <summary>
    /// ���D�\��
    /// </summary>
    //�n�`�NMonoBehaviour�n�e�{���A
    //�Y�D���h�ݨ�Unity\Edit\Preferences\External Tools\���Script Editor2019
    public class SystemJump : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����
        /*��� Field : �O�s��k 
         * �y�k : �׹��� ��쪺������� ���ۭq�W��(�Ǧ�) =���w �w�]��);
         * �׹��� : �������}�M�p�H
         * ���}public: ��ܦb���O�A���\��L���O�s��
         * �p�Hprivate: ����ܦb���O�A�����\��L���O�s��(�ʸ�)
         */

        /*[]���A������Attritube�ݩʡA�ε��ѵ��B�~�\��
         * SerializeField�ǦC�����:�N�p�H�����ܦb���O�W�A�i�H�W�[���Ѽ��D�B���ܡB�d��
         * Header���D : �i�H�ϥΤ��� ("���D����")
         * Tooltip���� : �i�H�ϥΤ���("����Ԫ��t�����D����")
         * Range�d�� : �ȭ��ƭ��������(0,3000)
         * �H�U�o��private���׹��l�L�k�bnormal�Ҧ��U�Q�ݨ��A�i�H������debug�Ҧ��U�˵�
         */
        [SerializeField, Header("���D����"), Tooltip("����Ԫ��t�����D����"), Range(0, 3000)]
        private float heightJump = 350;
        //[SerializeField]
        private Animator ani; //�ʵe������A�@�Ө��⨭�W�q�`�u�|���@��
        //[SerializeField]
        private Rigidbody2D rig; //2D����:�]�w�B�ʦ欰�p���ʡB����M�I��
        //[SerializeField]
        private bool clickJump; // Ĳ�o���D

        #endregion

        #region �\��:��@�Өt�Ϊ�������k
        /// <summary>
        /// ���D�\��
        /// </summary>
        //��kMethod, �ߺD�H�j�g�}�Y�R�W
        //�y�k : �׹��� �Ǧ^���A ��k�W��(�Ѽ�){�{��}
        private void JumpKey()
        {
            //�ݩ�.��k, �u�n�O��L�ηƹ�����J���OInput���ݩ�
            //�p�G ���a ���U �ť��� �N���W ���D
            //if �M switch���OC#���P�_��
            //if �y�k : if (���L��){���L�Ȭ�TRUE�ɩҭn���檺�{��}
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D��~");
                clickJump = true;
            }
        }
        private void JumpForce()
        {
            //�p�G ���a ���U �ť��� �N���ͤ@�ө��W�����O
            //if �M switch���OC#���P�_��
            //if �y�k : if (���L��){���L�Ȭ�TRUE�ɩҭn���檺�{��}
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false; //���@�U�N���@���N�n
            }
        }

        #endregion

        #region �ƥ�:�{���J�f
        /* Awake�@�w�n���bStart���e
         * �B�b�C������C���ɷ|����@��
         * �bAni�i�H�ݨ�Ԫ��t(Animator)�MRig�̬ݨ�Ԫ��t(Rigidbody 2D)
         */
        private void Awake()
        {
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();//�]�i�H�b�ݩʭ��O�����ԤJ
        }
        /* �}�l�ƥ�: ����C���ɷ|����@��
         * ��l�Ƴ]�w�A�Ҧp:��l�ƥͩR�ȩΪ�l�ƫe���ȵ���
         */
        private void Start()
        {
            //print("WELCOME TO MONICA GAME WORLD");//��play�|�b�̤U�誺����O���
        }
        /* ������OConsole�Ԩ�Inspector�U��A��ܪ��T�����ӷ|�`�`�ݭn�Ѧ�
         * ��s�ƥ�:�j���C�����60�� 60FPS Frame per second
         */
        private void Update()
        {
            //Input API��ĳ�AInput�o���ݩʭn�g�bUpdate�̭�
            //�I�s��k���y�k : ��k�W��(�������޼�);
            JumpKey();
        }

        //��Update���@�ˡA�T�w�C�����50�� 50FPS Frame per second
        private void FixedUpdate()
        {
            JumpForce();
        }

        #endregion

    }
}



