#include <QCoreApplication>
#include <iostream>
#include <string>
#include "UI.h"

using namespace std;

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);


    UI::Header();
    UI::ColumnLabels();
    UI::AskForOption(1);


    return 0;
}
