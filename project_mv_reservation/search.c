#include <stdio.h>
#include <Windows.h>
#include <conio.h>
#include <string.h>
#include "struct.h"
#include "function.h"
#include "util.h"

void search() {
	system("cls");
	printf("======================================================================================================\n");
	printf("                ___   _  _______    _______  ___  __    _  _______  __   __  _______\n");
	printf("               |   | | ||  _    |  |       ||   ||  |  | ||       ||  |_|  ||   _   |\n");
	printf("               |   |_| || |_|   |  |       ||   ||   |_| ||    ___||       ||  |_|  |\n");
	printf("               |      _||       |  |       ||   ||       ||   |___ |       ||       |\n");
	printf("               |     |_ |  _   |   |      _||   ||  _    ||    ___||       ||       |\n");
	printf("               |    _  || |_|   |  |     |_ |   || | |   ||   |___ | ||_|| ||   _   |\n");
	printf("               |___| |_||_______|  |_______||___||_|  |__||_______||_|   |_||__| |__|\n");
	printf("\n");
	printf("======================================================================================================\n");
	printf("\n\n");
	printf("                                            �帣�� �˻�\n");
	printf("\n\n");

	FILE* fpr = fopen("d:/NOW_MV_LIST.txt", "rb");
	if (fpr == NULL) {
		printf("                                  ���� ����� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	NOW now_t = { 0, };
	char genre[20];
	printf("                                 ����������������������������������������������������������������\n");
	printf("                                 �� �˻��� �帣:                 ��\n");
	printf("                                 ����������������������������������������������������������������\n");
	printf("\n");
	printf("                        �帣 Ű����: �׼�, ����, ���, �ڹ̵�, ��Ÿ��, ����");
	gotoxy(48, 16);
	scanf(" %s", &genre);

	int i = 0;
	int count = 0;
	while (fread(&now_t, sizeof(now_t), 1, fpr) == 1) {
		if (strcmp(now_t.genre, genre) == 0) {
			gotoxy(25, 15 + i); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(25, 16 + i); printf("��                                                  ��\n");
			gotoxy(25, 17 + i); printf("��     ����:                                        ��");
			gotoxy(25, 18 + i); printf("��     �帣:                                        ��");
			gotoxy(25, 19 + i); printf("��                                                  ��");
			gotoxy(25, 20 + i); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(37, 17 + i); printf("                                       ");
			gotoxy(37, 17 + i); printf("<%s>", now_t.name);
			gotoxy(37, 18 + i); printf("                                       ");
			gotoxy(37, 18 + i); printf("%s", now_t.genre);
			count++; i += 6;
		}
	}
	fclose(fpr);
	if (count != 0) {
		printf("\n\n\n\n");
		printf("                     ���� ���� �� %s �帣�� �ش��ϴ� ��ȭ�Դϴ�.\n", genre);
		printf("                              �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	if (count <= 0) {
		printf("\n\n\n\n");
		printf("                     ���� ���� �� %s �帣�� �ش��ϴ� ��ȭ�� �����ϴ�.\n", genre);
		printf("                              �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
}