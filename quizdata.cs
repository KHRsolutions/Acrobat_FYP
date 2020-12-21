using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizdata : MonoBehaviour
{
 
  
 
    public static string[] dataset = new string[26];
    public static string[] A = new string[26];
    public static string[] B = new string[26];
    public static int[] check = new int[26];
    public static int marks = 0;
    public List<int> randomList = new List<int>();

    public Text Score_UIText;
    public Text Score_A;
    public Text Score_B;
    public Text SCORE;
    public static int counter = 0;
    int index;

    public GameObject score;


    void Start()
    {
        dataset[0] = "Every Web page has a unique address called a(n) ";
        A[0] = "URL";
        B[0] = "ARL";


        dataset[1] = "It is also called the brain of the computer, is responsible for processing data.";
        A[1] = "hard disk";
        B[1] = "Printers";


        dataset[2] = "which of the following is example of storage device except";
        A[2] = "YES";
        B[2] = "NO";


        dataset[3] = ".who is the minister of education? ";
        A[3] = "Shafqat Mehmood";
        B[3] = "Pervaiz khatak";


        dataset[4] = ".Who is the minister of science and technology? ";
        A[4] = "Fawad Ahmed Chaudhary";
        B[4] = "Asad Umar";


   /*     dataset[5] = "Do you find yourself becoming confused in the middle of a conversation and having to stop?";
        A[5] = "YES";
        B[5] = "NO";



        dataset[6] = "Do you struggle to remember words, date, or events?";
        A[6] = "YES";
        B[6] = "NO";



        dataset[7] = "Do you lose things and/or sense that people have stolen them?";
        A[7] = "YES";
        B[7] = "NO";


        dataset[8] = "Have you or others noticed changes in your personality, such as becoming easily upset or anxious? ";
        A[8] = "YES";
        B[8] = "NO";

    */

        callData();

    }

    void Update()
    {


        if (AA.mcq == 'A')
        {

            AA.mcq = 'E';
            callData();

        }

        if (AA.mcq == 'B')
        {


            marks++;
            AA.mcq = 'E';
            callData();
        }




    }
    public void callData()
    {

        if (counter <= 7)
        {


            index++;
            getData();


        }
        else
        {
            score.SetActive(true);
            Debug.Log(marks);
            SCORE.text = marks.ToString();
        }
    }
    public void getData()
    {
        counter++;
        Score_UIText.text = dataset[index];
        Score_A.text = A[index];
        Score_B.text = B[index];
    }
}
