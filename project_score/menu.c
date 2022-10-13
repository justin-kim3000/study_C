#include "def.h"
#include <stdio.h>
#include "menu.h"
#include <Windows.h>

int main_menu()
{
	printf("=========================\n");
	printf("스마트 학사 관리 v1.0\n");
	printf("=========================\n");
	printf("1. 학생 정보 입력\n");
	printf("2. 학생 정보 보기\n");
	printf("3. 학생 정보 삭제\n");
	printf("4. 학생 정보 수정\n");
	printf("5. 정보 검색\n");
	printf("6. 데이터 초기화\n");
	printf("7. 종료\n");
	printf("=========================\n");
	printf("메뉴 선택:");
	int menu = 0;
	scanf("%d", &menu);

	if (menu == 1 || menu == 2 || menu == 3 || menu == 4 || menu == 5 || menu == 6 || menu == 7)
	{
		return menu;
	}


}