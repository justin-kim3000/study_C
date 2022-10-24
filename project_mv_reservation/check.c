#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <Windows.h>
#include <conio.h>
#include "struct.h"
#include "util.h"
#include "function.h"

void checkIn() {
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
	printf("                                            ���� ���� ��ȸ\n");
	printf("\n\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    ��        1. �α���        ��\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    ��      2. ��ȸ�� ��ȸ     ��\n");
	printf("                                    ������������������������������������������������������\n");
	printf("\n\n");
	printf("                                                          ��� ���� (0���� ���ư���): ");
	int select = 0;
	while (1) {
		scanf("%d", &select);
		if (select == 2) {
			check();
			return;
		}
		else if (select == 1) {
			check_mem();
			return;
		}
		else if (select == 0) {
			return;
		}
		else {
			gotoxy(0, 23);
			printf("                                                          ��� ���� (0���� ���ư���):  ");
			rewind(stdin);
			gotoxy(86, 23);
		}
	}
	return;
}

void check() {
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
	printf("                                           ���� ���� ��ȸ\n");
	FILE* fp = fopen("D:/book.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	BOOK book_t = { 0, };

	char name[10] = { 0, };
	char phone[20] = { 0, };

	printf("\n\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    �� �����ڸ�:               ��\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    �� ��ȭ��ȣ:               ��\n");
	printf("                                    ������������������������������������������������������\n");
	gotoxy(48, 16); scanf("%s", &name);
	gotoxy(48, 19); scanf("%s", &phone);
	printf("\n\n\n");
	printf("                                     ���� ������ ��ȸ���Դϴ�...\n");
	Sleep(2000);

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
	printf("                                          %s���� ���� ����\n", name);
	printf("\n\n\n");

	int count = 0;
	int line1 = 0;
	while (fread(&book_t, sizeof(book_t), 1, fp) == 1) {
		if (strcmp(name, book_t.name) == 0 && strcmp(phone, book_t.phone) == 0) {
			gotoxy(25, 15 + line1); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(25, 16 + line1); printf("��                  %d��° ���� ����                 ��\n", ++count);
			gotoxy(25, 17 + line1); printf("��     ����:                                        ��");
			gotoxy(25, 18 + line1); printf("��     �¼�:                                        ��");
			gotoxy(25, 19 + line1); printf("��     ���� �ݾ�:                                   ��");
			gotoxy(25, 20 + line1); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(37, 17 + line1); printf("                                       ");
			gotoxy(37, 17 + line1); printf("<%s>", book_t.movie);
			gotoxy(37, 18 + line1); printf("                                       ");
			gotoxy(37, 18 + line1); printf("%s %s %s", book_t.seat1, book_t.seat2, book_t.seat3);
			gotoxy(42, 19 + line1); printf("                     ");
			gotoxy(42, 19 + line1); printf("%d", book_t.price);
			//printf("                                          %d��° ���� ����\n", ++count);
			//printf("                                          ��ȭ: %s\n", book_t.movie);
			//printf("                                          �¼�: %s %s %s\n", book_t.seat1, book_t.seat2, book_t.seat3);
			//printf("                                          ���� �ݾ�: %d\n", book_t.price);
			printf("\n");
			line1 += 6;
		}
	}
	if (count == 0) {
		fclose(fp);
		printf("                                     ������ ���� ������ �����ϴ�.\n");
		printf("                                      �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	printf("\n\n");
	int i;
	printf("                            ������������������������������             ������������������������������\n");
	printf("                            �� 1. ���ư��� ��             �� 2. ���� ��Ҧ�\n");
	printf("                            ������������������������������             ������������������������������\n");
	printf("\n\n");
	printf("                                                                            ��� ����: ");
	scanf("%d", &i);
	printf("\n\n");
	while (1) {

		if (i == 1) {
			fclose(fp);
			return;
		}
		else if (i == 2) {
			int i = 0 + (count*6);
			fclose(fp);
			/*
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
			printf("                                             ���� ���\n");
			*/
			char movie[40] = { 0, };
			char seat[5] = { 0, };
			gotoxy(0, 16 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 17 + i); printf("                               �� ����� ��ȭ:                       ��                          \n");
			gotoxy(0, 18 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 19 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 20 + i); printf("                               �� ����� �¼�:                       ��                          \n");
			gotoxy(0, 21 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 22 + i); printf("                                                                                                   \n");
			gotoxy(0, 23 + i); printf("                        ������ �¼��� �������� ���, ù ��° �¼��� �Է��ϼ���.                        ");
			gotoxy(0, 24 + i); printf("                                    0�� �Է��ϸ� �޴��� ���ư��ϴ�.                        ");
			gotoxy(46, 17 + i); scanf(" %[^\n]s", &movie);
			if (strcmp(&movie, "0") == 0) {
				return;
			}
			gotoxy(46, 20 + i); scanf("%s", &seat);
			delete_name(name, phone, movie, seat);
			return;
		}
		else if (i == 0) {
			fclose(fp);
			return;
		}
		else {
			rewind(stdin);
			gotoxy(0, 28); printf("                                                                            ��� ����:    ");
			gotoxy(0, 28); printf("                                                                            ��� ����: ");
			scanf("%d", &i);
		}
	}
	fclose(fp);
	return;
}

void delete_name(char* name, char* phone, char* movie, char* seat) {
	FILE* fp = fopen("d:/book.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n");
		printf("\n                                   �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}

	BOOK src = { 0, };
	static BOOK dest[256] = { 0, };
	int idx = 0;
	int found = 0;
	while (fread(&src, sizeof(BOOK), 1, fp) == 1) {
		if (strcmp(name, src.name) == 0 && strcmp(phone, src.phone) == 0 && strcmp(movie, src.movie) == 0 && strcmp(seat, src.seat1) == 0) {
			found = 1;
		}
		else {
			dest[idx++] = src;
		}
	}
	fclose(fp);

	if (found == 0) {
		printf("\n\n\n\n");
		printf("                                �Է��Ͻ� ���� ������ �������� �ʽ��ϴ�.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}

	fp = fopen("d:/book.txt", "wb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n");
		printf("\n                                   �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return; return;
	}
	for (int i = 0; i < 256; i++) {
		if (strcmp(dest[i].name, "") != 0) {
			fwrite(&dest[i], sizeof(BOOK), 1, fp);
		}
		else break;
	}
	fclose(fp);
	memset(dest, 0, sizeof(BOOK) * 256);
	printf("\n\n\n\n");
	printf("                                     ���Ÿ� ����ϴ� ���Դϴ�...\n");
	Sleep(1500);
	printf("\n");
	printf("                                     ���� ��Ұ� �Ϸ�Ǿ����ϴ�.\n");
	printf("                                    �ƹ� Ű�� ������ ���ư��ϴ�.\n");
	_getch();
	return;
}

void check_mem() {
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
	printf("                                           ���� ���� ��ȸ\n");
	FILE* fp = fopen("D:/book_mem.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	BOOK_MEM book_t = { 0, };

	char id[10] = { 0, };
	char passwd[20] = { 0, };

	printf("\n\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    �� ID:                     ��\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    ������������������������������������������������������\n");
	printf("                                    �� ��й�ȣ:               ��\n");
	printf("                                    ������������������������������������������������������\n");
	gotoxy(42, 16);
	scanf("%s", id);
	gotoxy(48, 19);
	scanf("%s", passwd);
	int login_chk = 0;
	login_chk = check_ID(id, passwd);
	if (login_chk == 0) {
		printf("\n\n\n");
		printf("                            �������� �ʴ� ID�̰ų�, ��й�ȣ�� Ʋ�Ƚ��ϴ�.\n");
		printf("                                     Ȯ�� �� �ٽ� �õ����ּ���.\n");
		printf("                                    �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	printf("\n\n\n");
	printf("                                       �α��ο� �����߽��ϴ�.\n");
	printf("                                     ���� ������ ��ȸ���Դϴ�...\n");
	Sleep(2000);

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
	printf("                                          %s���� ���� ����\n", id);
	printf("\n\n\n");

	int count = 0;
	int line2 = 0;
	while (fread(&book_t, sizeof(BOOK_MEM), 1, fp) == 1) {
		if (strcmp(id, book_t.id) == 0 && strcmp(passwd, book_t.pass) == 0) {
			gotoxy(25, 15 + line2); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(25, 16 + line2); printf("��                  %d��° ���� ����                 ��\n", ++count);
			gotoxy(25, 17 + line2); printf("��     ����:                                        ��");
			gotoxy(25, 18 + line2); printf("��     �¼�:                                        ��");
			gotoxy(25, 19 + line2); printf("��     ���� �ݾ�:                                   ��");
			gotoxy(25, 20 + line2); printf("��������������������������������������������������������������������������������������������������������\n");
			gotoxy(37, 17 + line2); printf("                                       ");
			gotoxy(37, 17 + line2); printf("<%s>", book_t.movie);
			gotoxy(37, 18 + line2); printf("                                       ");
			gotoxy(37, 18 + line2); printf("%s %s %s", book_t.seat1, book_t.seat2, book_t.seat3);
			gotoxy(42, 19 + line2); printf("                     ");
			gotoxy(42, 19 + line2); printf("%d", book_t.price);
			printf("\n");
			line2 += 6;
			//printf("                                          %d��° ���� ����\n", ++count);
			//printf("                                          ��ȭ: %s\n", book_t.movie);
			//printf("                                          �¼�: %s %s %s\n", book_t.seat1, book_t.seat2, book_t.seat3);
			//printf("                                          ���� �ݾ�: %d\n", book_t.price);
			printf("\n");
		}
	}
	if (count == 0) {
		fclose(fp);
		printf("                                     ������ ���� ������ �����ϴ�.\n");
		printf("                                      �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	printf("\n\n");
	int i;
	printf("                            ������������������������������             ������������������������������\n");
	printf("                            �� 1. ���ư��� ��             �� 2. ���� ��Ҧ�\n");
	printf("                            ������������������������������             ������������������������������\n");
	printf("\n\n");
	printf("                                                                           ��� ����: ");
	scanf("%d", &i);
	printf("\n\n");
	while (1) {
		if (i == 1) {
			fclose(fp);
			return;
		}
		else if (i == 2) {
			int i = 0 + (count * 6);
			fclose(fp);
			/*
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
			printf("                                             ���� ���\n");
			*/
			char movie[40] = { 0, };
			char seat[5] = { 0, };
			printf("\n\n");
			gotoxy(0, 16 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 17 + i); printf("                               �� ����� ��ȭ:                       ��                          \n");
			gotoxy(0, 18 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 19 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 20 + i); printf("                               �� ����� �¼�:                       ��                          \n");
			gotoxy(0, 21 + i); printf("                               ����������������������������������������������������������������������������                          \n");
			gotoxy(0, 22 + i); printf("                                                                                                   \n");
			gotoxy(0, 23 + i); printf("                        ������ �¼��� �������� ���, ù ��° �¼��� �Է��ϼ���.                        ");
			gotoxy(0, 24 + i); printf("                                    0�� �Է��ϸ� �޴��� ���ư��ϴ�.                        ");
			gotoxy(46, 17 + i); scanf(" %[^\n]s", &movie);
			if (strcmp(&movie, "0") == 0) {
				return;
			}
			gotoxy(46, 20 + i); scanf("%s", &seat);
			delete_mem(id, passwd, movie, seat);
			return;
		}
		else {
			rewind(stdin);
			gotoxy(0, 28); printf("                                                                            ��� ����:    ");
			gotoxy(0, 28); printf("                                                                            ��� ����: ");
			scanf("%d", &i);
		}
	}
	fclose(fp);
	return;
}

void delete_mem(char* id, char* pass, char* movie, char* seat) {
	FILE* fp = fopen("d:/book_mem.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n");
		printf("\n                                   �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}

	BOOK_MEM src = { 0, };
	static BOOK_MEM dest[256] = { 0, };
	int idx = 0;
	int found = 0;
	while (fread(&src, sizeof(BOOK_MEM), 1, fp) == 1) {
		if (strcmp(id, src.id) == 0 && strcmp(pass, src.pass) == 0 && strcmp(movie, src.movie) == 0 && strcmp(seat, src.seat1) == 0) {
			found = 1;
		}
		else {
			dest[idx++] = src;
		}
	}
	fclose(fp);

	if (found == 0) {
		printf("\n\n\n\n\n");
		printf("                                �Է��Ͻ� ���� ������ �������� �ʽ��ϴ�.\n\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}

	fp = fopen("d:/book_mem.txt", "wb");
	if (fp == NULL) {
		printf("\n\n\n\n");
		printf("                                 ���� ���� DB�� �ҷ����� ���߽��ϴ�.\n");
		printf("                                      ��� �� �ٽ� �õ����ּ���.\n");
		printf("\n                                   �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	for (int i = 0; i < 256; i++) {
		if (strcmp(dest[i].id, "") != 0) {
			fwrite(&dest[i], sizeof(BOOK_MEM), 1, fp);
		}
		else {
			break;
		}
	}
	fclose(fp);
	memset(dest, 0, sizeof(BOOK_MEM) * 256);
	printf("\n\n\n");
	printf("                                     ���Ÿ� ����ϴ� ���Դϴ�...\n");
	Sleep(1500);
	printf("\n");
	printf("                                     ���� ��Ұ� �Ϸ�Ǿ����ϴ�.\n");
	printf("                                    �ƹ� Ű�� ������ ���ư��ϴ�.\n");
	_getch();
	return;
}