#include "def.h"
#include <stdio.h>
#include <windows.h>
#include "cui.h"

void gotoxy(int x, int y)
{
	COORD pos = { x, y };
	// win32 api
	SetConsoleCursorPosition(
		GetStdHandle(STD_OUTPUT_HANDLE), pos);
}

void title()
{
	int x = 5;
	int y = 1;
	gotoxy(x, y + 0); printf("■■■■■■■■■■■■■■■■■");
	gotoxy(x, y + 1); printf("■                              ■");
	gotoxy(x, y + 2); printf("■                              ■");
	gotoxy(x, y + 3); printf("■                              ■");
	gotoxy(x, y + 4); printf("■                              ■");
	gotoxy(x, y + 5); printf("■                              ■");
	gotoxy(x, y + 6); printf("■                              ■");
	gotoxy(x, y + 7); printf("■■■■■■■■■■■■■■■■■");
	gotoxy(x + 6, y + 2); printf("스마트 학사 관리 App 1.0");
	gotoxy(x + 16, y + 4); printf("날짜:2022/10/11");
	gotoxy(x + 16, y + 5); printf("작성:박상신");
	
	gotoxy(x, y + 10); printf("※※※ 도움말 ※※※");
	gotoxy(x, y + 12); printf("▶ 학생정보입력	: 학생, 교수, 전공 과목등을 입력합니다");
	gotoxy(x, y + 14); printf("▶ 학생정보보기	: 등록된 학사 관리 정보를 출력합니다");
	gotoxy(x, y + 16); printf("▶ 학생정보수정	: 등록된 학사 관리 정보를 수정합니다");
	gotoxy(x, y + 18); printf("▶ 학생정보삭제	: 등록된 학사 관리 정보를 삭제합니다");
	gotoxy(x, y + 20); printf("▶ 정보 검색	: 검색할 단어르 입력하여 원하는 정보를 검색합니다");
	gotoxy(x, y + 22); printf("▶ 데이터 초기화	: 등록된 모든 정보를 삭제하여 초기화합니다");
	gotoxy(x, y + 26); printf("▶ 메인메뉴 이동은 아무키나 누르세요! ◀");



}

void set_cursor_type(CURSOR_TYPE type)
{
	CONSOLE_CURSOR_INFO curinfo;
	memset(&curinfo, 0, sizeof(curinfo));
	switch (type) {
	case NOCURSOR:
		curinfo.dwSize = 1;
		curinfo.bVisible = FALSE;
		break;
	case SOLID_CURSOR:
		curinfo.dwSize = 100;
		curinfo.bVisible = TRUE;
		break;
	case NORMAL_CURSOR:
		curinfo.dwSize = 20;
		curinfo.bVisible = TRUE;
		break;
	}
	SetConsoleCursorInfo(
		GetStdHandle(STD_OUTPUT_HANDLE), &curinfo);
}

void fontcolor(FONT_COLOR color)
{
	SetConsoleTextAttribute(
		GetStdHandle(STD_OUTPUT_HANDLE), color);
}