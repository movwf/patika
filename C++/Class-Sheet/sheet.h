#include <iostream>
#include <cstring>

using namespace std;

namespace Sheet{

/*!
 * \brief Centers string into specified length
 * \param rowLength Length of space
 * \param inner String
 * \return
 */
string CenterRow(int rowLength, string inner){
    // Length of the string
    int innerLength = inner.length();
    // Space count
    int lengthDiff = rowLength - innerLength;
    // Difference of equal distribution
    int shiftLength = lengthDiff%2;
    int diff = ((lengthDiff - shiftLength)/2)-2;

    // If inner string given is longer than desired row length
    if(innerLength<=rowLength){
        return "|" + string(diff,' ') + inner + string(diff+shiftLength,' ') + "|";
    }else{return "";}
}

void Header(){
    cout<<"┌───────────────────────────────────────── •✧✧• ─────────────────────────────────────────┐"<<endl;
    cout<<"|  ██████╗██╗      █████╗ ███████╗███████╗      ███████╗██╗  ██╗███████╗███████╗████████╗ |"<<endl;
    cout<<"| ██╔════╝██║     ██╔══██╗██╔════╝██╔════╝      ██╔════╝██║  ██║██╔════╝██╔════╝╚══██╔══╝ |"<<endl;
    cout<<"| ██║     ██║     ███████║███████╗███████╗█████╗███████╗███████║█████╗  █████╗     ██║    |"<<endl;
    cout<<"| ██║     ██║     ██╔══██║╚════██║╚════██║╚════╝╚════██║██╔══██║██╔══╝  ██╔══╝     ██║    |"<<endl;
    cout<<"| ╚██████╗███████╗██║  ██║███████║███████║      ███████║██║  ██║███████╗███████╗   ██║    |"<<endl;
    cout<<"|  ╚═════╝╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝      ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝   ╚═╝    |"<<endl;
    cout<<"| 2021   Version : 0.1A                                          Teacher :                |"<<endl;
    cout<<"|───────────────────────────────────────── •✧✧• ─────────────────────────────────────────|"<<endl;
}

/*!
 * \fn ColumnLabels
 * \brief Column Labels for Data
 */
void ColumnLabels(){
    cout<<"|| Öğrenci Adı || Vize - 1 || Vize - 2 ||   Final  ||               Durum                ||"<<endl;
    cout<<"||---------------------------------------------------------------------------------------||"<<endl;
}

/*!
 *  \brief Use for printing each item
 *  \param A1 Student Name
 *  \param A2 Note - 1
 *  \param A3 Note - 2
 *  \param A4 Final Note
 *  \param A5 If Student is Passed the Class
*/
void Row(string A1, string A2, string A3, string A4, bool A5){
    cout<<"|" +
          CenterRow(17,A1) +
          CenterRow(14,A2) +
          CenterRow(14,A3) +
          CenterRow(14,A4) +
          // Checks if the first column value is empty to surpass
          (A1!=""
            ?A5
             ?CenterRow(43,"Başarılı")
             :CenterRow(43,"Başarısız")
            :CenterRow(40,"")) +
          "|"<<endl;
    cout<<"||---------------------------------------------------------------------------------------||"<<endl;
}

void Footer(){
    cout<<"└=========================================================================================┘"<<endl;
}

void Exit(){
    cout<<"┌=========================================================================================┐"<<endl;
    cout<<"|                     Uygulamamızı kullandığınız için teşekkürler.                        |"<<endl;
    cout<<"└=========================================================================================┘"<<endl;
}

void Seperator(){
    cout<<"|=========================================================================================|"<<endl;
}

/*!
 * \brief Showing All Data
 * \param dataLength Database Row Size
 * \param studentData Database
 */
void ShowData(int dataLength, string studentData[][4]){
    // Iterate through rows
    for(int i = 0;i<dataLength;i++){
        // Calculate if student is failed/succeed
        bool gecer;
        // If student name is not empty
        if(studentData[i][0]!=""){
            gecer = ((
                         // Only 40% of sum of visas note
                         ((stoi(studentData[i][1])+stoi(studentData[i][2]))*4/10)
                         // Only 50% of final note
                         +(stoi(studentData[i][3])*6/10)
                    )>50);
        }else{ gecer = false; }

        // Print i-th row
        Row(studentData[i][0],studentData[i][1],studentData[i][2],studentData[i][3],gecer);
    }

}

/*!
 * \fn AddNewData
 * \brief Adding new student data to database
 * \param dataRowSize Student count stored in database
 * \param studentData Database
 */
void AddNewData(int dataRowSize, string studentData[][4]){
    string addNew;
    int emptyIndex = -1;

    // Ask for addition
    cout<<"| Yeni bir öğrenci girişi yapmak ister misiniz?(y/n)  : ";
    cin>>addNew;

    // If answer is y -> Yes
    if(addNew=="y"){
        // Iterate through database to find empty row
        for(int i = 0;i<dataRowSize;i++){
            if(studentData[i][0]==""){
                emptyIndex = i;
                break;
            }
        }
        // If there is an empty row
        if(emptyIndex!=-1){
            string firstName, secondName, first, second, final;
            // Ask for students name
            cout<<"| Öğrenci Adı  : ";
            cin>>firstName;
            cin>>secondName;
            // First visa note
            cout<<"| 1. Vize Notu : ";
            cin>>first;
            // Second visa note
            cout<<"| 2. Vize Notu : ";
            cin>>second;
            // Final visa note
            cout<<"| Final Notu : ";
            cin>>final;

            // Append new student data into database
            studentData[emptyIndex][0] = firstName + " " + secondName;
            studentData[emptyIndex][1] = first;
            studentData[emptyIndex][2] = second;
            studentData[emptyIndex][3] = final;

            // Show updated data
            Seperator();
            ColumnLabels();
            ShowData(dataRowSize,studentData);
            Footer();
            AddNewData(dataRowSize, studentData);

        }else{
            // If database is full end app with an error
            Seperator();
            cout<<"||  Veritabanı Dolu!                                                                     ||"<<endl;
            Footer();
            Exit();
        }

    }else{
        // If not wanted to add new student
        Exit();
    }
}



}
