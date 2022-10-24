#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <Windows.h>
#include <conio.h>
#include "struct.h"
#include "function.h"

int main() {
	SetConsoleTitle(TEXT("KB 시네마 영화 예매 시스템"));
	system("mode con cols=102 lines=60");
	intro();
	Sleep(2000);
	system("cls");
	while (1) {
		switch (main_menu()) {
		case RESERVATION:
			system("cls");
			choose_List(print_List());
			break;
		case CHECK:
			system("cls");
			checkIn();
			break;
		case RECOMMEND:
			system("cls");
			my_rec();
			break;
		case GENRE_SEARCH:
			system("cls");
			search();
			break;
		case MANAGE:
			system("cls");
			admin_menu();
			break;
		case HELP:
			help();
			break;
		case QUIT:
			system("cls");
			quit();
		}
		system("cls");
	}
}
