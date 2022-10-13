#include "def.h"
#include <stdio.h>
#include <windows.h>
#include <stdlib.h>
#include <conio.h>
#include "cui.h"
#include "menu.h"
#include "haksa.h"
#include "util.h"
#include "file_util.h"

int main()
{
	// 콘솔창 최대 크기
	ShowWindow(GetConsoleWindow(), SW_MAXIMIZE);
	fontcolor(LIGHT_CYAN);
	set_cursor_type(NOCURSOR);
	title();
	_getch();
	system("cls"); // 외부 실행파일을 실행
	fontcolor(LIGHT_GREEN);
	set_cursor_type(NORMAL_CURSOR);
	//get_time();

	while (1) {
		switch (main_menu()) {
		case MA_INPUT:
			std_lecture_input();
			break;
		case MA_SHOW:
			lect_read();
			break;
		case MA_DEL:
			printf("데이터 삭제\n");
			char name[20] = { 0, };
			printf("삭제할 이름을 입력:");
			scanf("%s", name);
			lect_delete(name);
			break;
		case MA_UPDATE:
			printf("데이터 수정\n");
			break;
		case MA_SEARCH:
		{
			char name[20] = { 0, };
			printf("검색할 이름을 입력:");
			scanf("%s", name);
			lect_search2(name);
			break;
		}
		case MA_INIT:
			lect_init();
			break;
		case MA_EXIT:
			printf("앱을 종료합니다\n");
			exit(0);
		default: {
			printf("\n");
			printf("1~7 사이에 숫자를 넣으세요. \n");
			printf("\n");
			main_menu();
			break;
		}
		}
		system("pause");
		system("cls");
	}
}