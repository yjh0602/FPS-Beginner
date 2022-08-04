using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
    public class Person
    {
        protected int age;    //C#������ ��� �ϳ��ϳ��� ���������ڷ� ����
        public string name;
        public virtual void ShowVirtual()   //virtual�� �����Լ� ������, �ڽĿ����� override Ű���� �ٿ���
        {
            Debug.Log("Person�� ShowVirtual()");
        }
        public void ShowOverriding()        //virtual Ű���� ���� �ڽĿ��� �����Ǹ� �ϸ� �Ϲ� �������̵�
        {
            Debug.Log("Person�� ShowOverriding()");
        }
    }

    public class Teacher : Person
    {
        public override void ShowVirtual()
        {
            Debug.Log("Teacher�� ShowVirtual()");
        }
        public void ShowOverriding()
        {
            Debug.Log("Teacher�� ShowOverriding()");
        }
    }


    public class Monster
    {
        public string name;
        private int hp;
        private int exp;

        public void Set(string name,int hp) 
        {
            this.name = name; // c#������ �����Ͱ� ��� this -> �� �ƴ� this. �̴�.
            this.hp = hp;
        }
        public void Info()
        {
            Debug.Log(name + hp);        
        }

        public virtual void Hit(int damage)
        {
            
        }
    }
    public struct StructMonster
    {
        public string name;
        private int hp;
        private int exp;

        public void Set(string name, int hp)
        {
            this.name = name; // c#������ �����Ͱ� ��� this -> �� �ƴ� this. �̴�.
            this.hp = hp;
        }
        public void Info()
        {
            Debug.Log(name + hp);
        }
    }

    public class Dragon : Monster
    {
        public override void Hit(int damage)
        {
            Debug.Log("Dragon �� ���ظ� ���ݸ� �Դ´� 5�� ���ظ� ����");
        }
    }
    public class Slime : Monster
    {
        public override void Hit(int damage)
        {
            Debug.Log("Slime �� ���ظ� �ι� �Դ´� 20�� ���ظ� ����");
        }
    }


    //C#������ ����ü 
    public struct PositionStruct
    {
        public float x;
        public float y;

        public void Set(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Debug.Log(x + "," + y);
        }
    }
    //C#������ Ŭ���� 
    public class PositionClass
    {
        public float x;
        public float y;

        public void Set(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void Show()
        {
            Debug.Log(x + "," + y);
        }
    }





    void SwapValue(int numA, int numB)
    {
        int temp;
        temp = numA;
        numA = numB;
        numB = temp;
    }

    void SwapRef(ref int numA, ref int numB)
    {
        int temp;
        temp = numA;
        numA = numB;
        numB = temp;
    }

    int Sum(int numA, int numB) // return ������ �ѱ��
    {
        int result = 0;
        result = numA + numB;
        return result;
    }
    //ref :�ݹ��� ���۷���
    //in : �ݹ��� ���۷����ε� �б⸸ ����
    //out : �ݹ��� ���۷����ε� ���⸦ ������ �ؾߵ�
    void SumRef(int numA, int numB ,ref int result) // ref �ּ� ������ �ѱ��
    {
        result = numA + numB;
    }
    
    // main
    void Start()
    {

       
        int inputA = 10;
        int inputB = 30;
        int result = 0;

        Debug.Log(inputA + "," + inputB);
        SwapValue(inputA, inputB);
        Debug.Log(inputA + "," + inputB);

        Debug.Log(inputA + "," + inputB);
        SwapRef(ref inputA,ref inputB);
        Debug.Log(inputA + "," + inputB);

        Debug.Log(Sum(inputA, inputB)); // return ���� ��ȯ

        SumRef(inputA, inputB,ref result); // ref�� result �� ��ȯ
        Debug.Log(result);
       
        //int arr[10]; c++���� �迭
        // c#���� �迭 int[] arr = new int[10]; 

        float[] arr = new float[30];

        for(int i=0; i< arr.Length; i++)
        {
            arr[i] = i;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);           
        }

        //C#�� �⺻������Ÿ���� ����ü�� �̷��������.

        //C#���� �������� ������ ����� ����.
        //C++�� ������ ����� �����Ϳ� ���� ������� �Ǽ��� �����ϱ����� ������ ��.
        //�޸��� ������ �������÷��� ��� ģ���� ����.

        // C#�� �⺻������ C++���� ������ ���� �д�. ���� �� �����ϴ�.
        // bool tempBool = true;
        //tempBool = 1; boolŸ�Կ� ������ 1�� C#���� ���� �� ����. ������ true false��

        for (int i = 0; i < 10; i++)
        {
            //cout<<"Hello World"<<endl;
            //    Debug.Log("Hello World" + "TEST" + i);
        }



        //Person person = new Person(); //C#���� Ŭ������ ������ new�� �ؼ� �����Ҵ� �� �ؾ��Ѵ�.
        //Monster monsterA = new Monster();
        //monsterA.name = "����A";

        //Debug.Log(monsterA.name);
        //monsterA.Set("���", 100);
        //monsterA.Info();


        // ���� �Լ� ���
        Dragon dragon = new Dragon();
        Slime slime = new Slime();

        Monster monster = dragon;
        monster.Hit(10);

        monster = slime;
        monster.Hit(10);


     
    }
}

////����ü�� Ŭ����
//PositionStruct positionStruct = new PositionStruct();
//positionStruct.Set(3.5f, 2.4f);
//PositionClass positionClass = new PositionClass();
//positionClass.Set(3.5f, 2.4f);

////����ü�� = ���� �����Ҷ� �� ��ü�� �����ϴ� ���� ���簡 �Ͼ��.
//PositionStruct tempStruct;
//tempStruct = positionStruct;

////Ŭ������ = ���� �����Ҷ� �ּҸ� �����ϴ� ���� ���簡 �Ͼ��.
//PositionClass tempClass;
//tempClass = positionClass;

//tempStruct.Set(5.5f, 5.5f);
//tempClass.Set(5.5f, 5.5f);

//positionStruct.Show(); //����ü�� ��������� ���� ���簡 �Ǿ��⶧���� ������ ������� ����
//positionClass.Show(); //Ŭ������ ��������� �ּҰ� ���簡 �Ǿ��⶧���� ������ �����

//string�� ����ϸ� Ŭ�������� ������ ��ȯ�� ���� �������簡 �Ͼ��.


// ��Ʈ��
//StructMonster structMonster = new StructMonster();

//structMonster.Set("��Ʈ��", 100);
//structMonster.Info();

//StructMonster tempStruct;
//tempStruct = structMonster;

//tempStruct.Set("�ٲ�", 50);
//structMonster.Info();       