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
            Debug.Log("아이템 사용 가능");
        }
        else
        {
            Debug.Log("아이템 사용 불가");
        }

            int health = 100;
        {
            if (health > 70)
            {
                Debug.Log("건강해요");
            }
            else if (health > 30)
            {
                Debug.Log("약간 지쳤어요");
            }
            else if(health >0)
            {
                Debug.Log("위험해요");
            }
            else
            {
                Debug.Log("사망");
            }
           

        }

        int mathScore = 95;
        int englishScore = 85;
        {
            if (mathScore > 60 && englishScore > 60)
            {
                if (mathScore + englishScore > 180)
                {
                    Debug.Log("우수합격");
                }
                else
                {
                    Debug.Log("일반 합격");
                }


            }
            if (mathScore < 60 && englishScore < 60)
            {
                Debug.Log("불합격");
            }
        }

       
    
   




    }
        

}


