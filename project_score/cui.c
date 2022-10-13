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
	gotoxy(x, y + 0); printf("������������������");
	gotoxy(x, y + 1); printf("��                              ��");
	gotoxy(x, y + 2); printf("��                              ��");
	gotoxy(x, y + 3); printf("��                              ��");
	gotoxy(x, y + 4); printf("��                              ��");
	gotoxy(x, y + 5); printf("��                              ��");
	gotoxy(x, y + 6); printf("��                              ��");
	gotoxy(x, y + 7); printf("������������������");
	gotoxy(x + 6, y + 2); printf("����Ʈ �л� ���� App 1.0");
	gotoxy(x + 16, y + 4); printf("��¥:2022/10/11");
	gotoxy(x + 16, y + 5); printf("�ۼ�:�ڻ��");
	
	gotoxy(x, y + 10); printf("�ءء� ���� �ءء�");
	gotoxy(x, y + 12); printf("�� �л������Է�	: �л�, ����, ���� ������� �Է��մϴ�");
	gotoxy(x, y + 14); printf("�� �л���������	: ��ϵ� �л� ���� ������ ����մϴ�");
	gotoxy(x, y + 16); printf("�� �л���������	: ��ϵ� �л� ���� ������ �����մϴ�");
	gotoxy(x, y + 18); printf("�� �л���������	: ��ϵ� �л� ���� ������ �����մϴ�");
	gotoxy(x, y + 20); printf("�� ���� �˻�	: �˻��� �ܾ �Է��Ͽ� ���ϴ� ������ �˻��մϴ�");
	gotoxy(x, y + 22); printf("�� ������ �ʱ�ȭ	: ��ϵ� ��� ������ �����Ͽ� �ʱ�ȭ�մϴ�");
	gotoxy(x, y + 26); printf("�� ���θ޴� �̵��� �ƹ�Ű�� ��������! ��");



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