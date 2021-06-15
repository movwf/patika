#include <iostream>
#include <string>
#include "Questions.h"

using namespace std;

namespace UI{

int CurrentPage = 1;

void Header(){
    cout<<"┌───────────────────────────────────────── •✧✧• ─────────────────────────────────────────┐"<<endl;
    cout<<"|            ███████╗██╗██████╗        ██████╗ █████╗ ███╗   ██╗██████╗ ██╗   ██╗         |"<<endl;
    cout<<"|            ██╔════╝██║██╔══██╗      ██╔════╝██╔══██╗████╗  ██║██╔══██╗╚██╗ ██╔╝         |"<<endl;
    cout<<"|            █████╗  ██║██║  ██║█████╗██║     ███████║██╔██╗ ██║██║  ██║ ╚████╔╝          |"<<endl;
    cout<<"|            ██╔══╝  ██║██║  ██║╚════╝██║     ██╔══██║██║╚██╗██║██║  ██║  ╚██╔╝           |"<<endl;
    cout<<"|            ███████╗██║██████╔╝      ╚██████╗██║  ██║██║ ╚████║██████╔╝   ██║            |"<<endl;
    cout<<"|            ╚══════╝╚═╝╚═════╝        ╚═════╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝    ╚═╝            |"<<endl;
    cout<<"| 2021   Version : 0.1A                                              Teacher :            |"<<endl;
    cout<<"|───────────────────────────────────────── •✧✧• ─────────────────────────────────────────|"<<endl;
}

void ColumnLabels(){
    cout<<"|  Soru - Açıklama                                                                        |"<<endl;
    cout<<"||---------------------------------------------------------------------------------------||"<<endl;
}

void Row(string Question){
    int diff = 85 - Question.length();
    cout<<"||  "<<Question<<string(diff,' ')<<"||"<<endl;
    cout<<"||---------------------------------------------------------------------------------------||"<<endl;
}

void DivisorHead(){
    cout<<"┌=========================================================================================┐"<<endl;
}

void Seperator(){
    cout<<"|=========================================================================================|"<<endl;
}


void Footer(){
    cout<<"└=========================================================================================┘"<<endl;
}

void ShowData(int PageNumber){
    int QuestionsLength = Questions::DataLength();
    int Start,End;

    CurrentPage = PageNumber;

    if(QuestionsLength >= PageNumber * 10){
        if(QuestionsLength >= (PageNumber + 1) * 10){
            Start = 10 * (PageNumber - 1);
            End = 10 * PageNumber;
            for(int i = Start; i < End ; i++){
                Row(Questions::getData(i));
            }
        }else{
            Start = 10 * (PageNumber - 1);
            End = (PageNumber * 10) + ( QuestionsLength % 10 ) - 1;
            //cout<<"Buradan"<<endl;
            for(int i = Start; i < End ; i++){
                Row(Questions::getData(i));
            }
        }

    }else if(QuestionsLength >= (PageNumber - 1) * 10){
        Start = 10 * (PageNumber - 1);
        End = QuestionsLength;
        for(int i = Start; i < End ; i++){
            Row(Questions::getData(i));
        }
    }else{
        cout<<"|  Sorular bitti                                                                          |"<<endl;
    }
    Footer();
}

void Exit(){
    cout<<"┌=========================================================================================┐"<<endl;
    cout<<"|                     Uygulamamızı kullandığınız için teşekkürler.                        |"<<endl;
    cout<<"└=========================================================================================┘"<<endl;
}



void AskForOption(int PageNumber){
    string option;
    ShowData(PageNumber);
    while(true){
        DivisorHead();
        cout<<"|  Bir soru sayısı giriniz. Çıkış \"e\" , \" exit \" - Bir sonraki sayfa : \" d \"              |"<<endl;
        cout<<"|  Lütfen seçeneği girin : ";
        cin>>option;

        if(option=="e" || option=="exit" ){
            Exit();
            break;
        }else if( option == "\n"){
            Exit();
            break;
        }else if(option == "d"){
            Footer();
            DivisorHead();
            ColumnLabels();

            ShowData(CurrentPage + 1);
            CurrentPage++;
        }else{
            Footer();
            // Run that program with id
            int id = stoi(option);
            Questions::RunProgram(id);
        }
    }
}

}
