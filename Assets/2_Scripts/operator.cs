using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Apple;

public class Operator : MonoBehaviour
{
    private void Start()
    {
        int level = 4;
        bool hasSpeicalITem = true;
        bool isInBattle = true; 

        if(level >= 5 && hasSpeicalITem && isInBattle)
        {
            Debug.Log("������ ��� ����");
        }
        else
        {
            Debug.Log("������ ��� �Ұ�");
        }

            int health = 100;
        {
            if (health > 70)
            {
                Debug.Log("�ǰ��ؿ�");
            }
            else if (health > 30)
            {
                Debug.Log("�ణ ���ƾ��");
            }
            else if(health >0)
            {
                Debug.Log("�����ؿ�");
            }
            else
            {
                Debug.Log("���");
            }
           

        }

        int mathScore = 95;
        int englishScore = 85;
        {
            if (mathScore > 60 && englishScore > 60)
            {
                if (mathScore + englishScore > 180)
                {
                    Debug.Log("����հ�");
                }
                else
                {
                    Debug.Log("�Ϲ� �հ�");
                }


            }
            if (mathScore < 60 && englishScore < 60)
            {
                Debug.Log("���հ�");
            }
        }

       
    
   




    }
        

}


