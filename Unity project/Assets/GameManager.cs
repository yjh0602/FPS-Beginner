using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  
    public class Person
    {
        protected int age;    //C#에서는 멤버 하나하나에 접근제한자로 구분
        public string name;
        public virtual void ShowVirtual()   //virtual로 가상함수 했으면, 자식에서는 override 키워드 붙여줌
        {
            Debug.Log("Person의 ShowVirtual()");
        }
        public void ShowOverriding()        //virtual 키워드 없이 자식에서 재정의를 하면 일반 오버라이딩
        {
            Debug.Log("Person의 ShowOverriding()");
        }
    }

    public class Teacher : Person
    {
        public override void ShowVirtual()
        {
            Debug.Log("Teacher의 ShowVirtual()");
        }
        public void ShowOverriding()
        {
            Debug.Log("Teacher의 ShowOverriding()");
        }
    }


    public class Monster
    {
        public string name;
        private int hp;
        private int exp;

        public void Set(string name,int hp) 
        {
            this.name = name; // c#에서는 포인터가 없어서 this -> 가 아닌 this. 이다.
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
            this.name = name; // c#에서는 포인터가 없어서 this -> 가 아닌 this. 이다.
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
            Debug.Log("Dragon 은 피해를 절반만 입는다 5의 피해를 입힘");
        }
    }
    public class Slime : Monster
    {
        public override void Hit(int damage)
        {
            Debug.Log("Slime 은 피해를 두배 입는다 20의 피해를 입힘");
        }
    }


    //C#에서의 구조체 
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
    //C#에서의 클레스 
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

    int Sum(int numA, int numB) // return 값으로 넘기기
    {
        int result = 0;
        result = numA + numB;
        return result;
    }
    //ref :콜바이 레퍼런스
    //in : 콜바이 레퍼런스인데 읽기만 가능
    //out : 콜바이 레퍼런스인데 쓰기를 무조건 해야됨
    void SumRef(int numA, int numB ,ref int result) // ref 주소 값으로 넘기기
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

        Debug.Log(Sum(inputA, inputB)); // return 으로 반환

        SumRef(inputA, inputB,ref result); // ref로 result 만 반환
        Debug.Log(result);
       
        //int arr[10]; c++에서 배열
        // c#에서 배열 int[] arr = new int[10]; 

        float[] arr = new float[30];

        for(int i=0; i< arr.Length; i++)
        {
            arr[i] = i;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);           
        }

        //C#의 기본데이터타입은 구조체로 이루어져있음.

        //C#에는 직접적인 포인터 사용이 없음.
        //C++의 강력한 기능인 포인터에 대해 사용자의 실수를 방지하기위해 제한을 둠.
        //메모리의 해제를 가비지컬렉터 라는 친구가 해줌.

        // C#은 기본적으로 C++보다 제한을 많이 둔다. 조금 더 엄격하다.
        // bool tempBool = true;
        //tempBool = 1; bool타입에 정수형 1은 C#에서 넣을 수 없음. 오로지 true false만

        for (int i = 0; i < 10; i++)
        {
            //cout<<"Hello World"<<endl;
            //    Debug.Log("Hello World" + "TEST" + i);
        }



        //Person person = new Person(); //C#에서 클래스는 무조건 new를 해서 동적할당 을 해야한다.
        //Monster monsterA = new Monster();
        //monsterA.name = "몬스터A";

        //Debug.Log(monsterA.name);
        //monsterA.Set("고블린", 100);
        //monsterA.Info();


        // 가상 함수 사용
        Dragon dragon = new Dragon();
        Slime slime = new Slime();

        Monster monster = dragon;
        monster.Hit(10);

        monster = slime;
        monster.Hit(10);


     
    }
}

////구조체와 클래스
//PositionStruct positionStruct = new PositionStruct();
//positionStruct.Set(3.5f, 2.4f);
//PositionClass positionClass = new PositionClass();
//positionClass.Set(3.5f, 2.4f);

////구조체는 = 으로 복사할때 값 자체를 복사하는 깊은 복사가 일어난다.
//PositionStruct tempStruct;
//tempStruct = positionStruct;

////클래스는 = 으로 복사할때 주소를 복사하는 얕은 복사가 일어난다.
//PositionClass tempClass;
//tempClass = positionClass;

//tempStruct.Set(5.5f, 5.5f);
//tempClass.Set(5.5f, 5.5f);

//positionStruct.Show(); //구조체는 깊은복사로 값이 복사가 되었기때문에 원본이 변경되지 않음
//positionClass.Show(); //클래스는 얕은복사로 주소가 복사가 되었기때문에 원본이 변경됨

//string을 사용하면 클래스지만 강제로 변환을 통해 깊은복사가 일어난다.


// 스트럭
//StructMonster structMonster = new StructMonster();

//structMonster.Set("스트럭", 100);
//structMonster.Info();

//StructMonster tempStruct;
//tempStruct = structMonster;

//tempStruct.Set("바뀐", 50);
//structMonster.Info();       