#include <stdio.h>
#include <Windows.h>
#include "util.h"

void gotoxy(int x, int y) {
	COORD pos = { x, y }; //win32 api
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}
