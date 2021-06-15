#include <QCoreApplication>
#include <iostream>
#include <string>
#include "sheet.h"

using namespace std;

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);

    // Initializing database
    string ogrenciData[5][4]{
        {"Ahmet Can","65","75","90"},
        {"Yavuz Ozer","100","100","100"},
        {"Mithat Er","10","10","30"}
    };
    // Row size of the database
    int dataLength = sizeof ogrenciData / sizeof ogrenciData[0];

    // Printing header of the app
    Sheet::Header();

    // Printing data column labels
    Sheet::ColumnLabels();

    // Showing Data
    Sheet::ShowData(dataLength, ogrenciData);

    // Completing design with footer
    Sheet::Footer();

    // New data addition loop
    Sheet::AddNewData(dataLength,ogrenciData);

    return 0;
}
