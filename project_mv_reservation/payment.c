#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <Windows.h>
#include <conio.h>
#include "function.h"
#include "struct.h"
#include "util.h"

void payment(char* movie, char seat[][5], int many) {
	BOOK book = { 0, };
	char seat1[30] = { 0, };
	strcpy(&book.movie, movie);
	strcpy(&book.seat1, seat[0]);
	if (seat[1][0] != NULL) {
		strcpy(&book.seat2, seat[1]);
	}
	if (seat[2][0] != NULL) {
		strcpy(&book.seat3, seat[2]);
	}
	//strcpy(&book.seat, seat);

	int price = 0;
	char sale;
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
	printf("                                            ��ȸ�� ����\n");
	printf("\n\n");
	printf("              ������ ��ȭ:                                        ���α� ���(Y/N): \n");
	printf("\n");
	printf("              ������ �¼�:                                        �̸�: \n");
	printf("\n");
	printf("                                                                  ��ȭ��ȣ: \n");
	printf("\n\n");
	printf("                                                                  ���� �ݾ�: \n");
	printf("\n\n");
	

	gotoxy(27, 15); printf("%s", movie);
	int a = 0;
	for (int i = 0; i < many; i++) {
		strcat(seat1, seat[i]);
		//gotoxy(27, 17+a); printf("%s", seat[i]);
		if (seat[i][0] == 'E' || seat[i][0] == 'F') {
			if (seat[i][1] >= '4' && seat[i][1] <= '7') {
				strcat(seat1, "(����Ʈ�ڽ�)");
				//gotoxy(30, 17+a); printf("(����Ʈ�ڽ�)");
				gotoxy(27, 17 + a);
				price += 13000; printf("%s", seat1);
			}
			else {
				strcat(seat1, "(�Ϲݼ�)");
				//gotoxy(30, 17+a); printf("(�Ϲݼ�)");
				gotoxy(27, 17 + a);
				price += 10000; printf("%s", seat1);
			}
		}
		else {
			strcat(seat1, "(�Ϲݼ�)");
			//gotoxy(30, 17+a); printf("(�Ϲݼ�)");
			gotoxy(27, 17 + a);
			price += 10000; printf("%s", seat1);
			
		}
		memset(&seat1, 0, sizeof(char) * 30);
		a++;
	}
	gotoxy(77, 22); printf("%d", price);

	
	gotoxy(84, 15);
	scanf(" %c", &sale);
	if (sale == 89 || sale == 121) {
		price = price / 10 * 9;
		gotoxy(77, 22); printf("         ");
		gotoxy(77, 22); printf("%d", price);
	}


	gotoxy(72, 17);
	scanf(" %s", book.name);
	gotoxy(76, 19);
	scanf(" %s", book.phone);
	gotoxy(0, 25); printf("                              �� �������� Ƽ���� �����Ͻðڽ��ϱ�?(Y/N): \n");
	gotoxy(73, 25);
	char agree;
	scanf(" %c", &agree);
	if (agree == 'y' || agree == 'Y') {
		FILE* fp = fopen("D:/book.txt", "ab");
		book.price = price;
		fwrite(&book, sizeof(BOOK), 1, fp);
		fclose(fp);

		printf("\n\n");
		printf("                                        ������ �Ϸ�Ǿ����ϴ�.\n"); 
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	else {
		printf("\n\n");
		printf("                                        ������ ��ҵǾ����ϴ�.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
}

void payment_mem(char* id, char* pass, char* movie, char seat[][5], int many) {
	BOOK_MEM book = { 0, };
	char seat1[30] = { 0, };
	strcpy(&book.id, id);
	strcpy(&book.pass, pass);
	strcpy(&book.movie, movie);
	strcpy(&book.seat1, seat[0]);
	if (seat[1][0] != NULL) {
		strcpy(&book.seat2, seat[1]);
	}
	if (seat[2][0] != NULL) {
		strcpy(&book.seat3, seat[2]);
	}

	int price = 0;
	char sale;
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
	printf("                                            %s�� ����\n", id);
	printf("\n\n");
	printf("              ������ ��ȭ:                                        ���α� ���(Y/N): \n");
	printf("\n");
	printf("              ������ �¼�:            \n");
	printf("\n");
	printf("\n");
	printf("\n\n");
	printf("                                                                  ���� �ݾ�: \n");
	printf("\n\n");

	gotoxy(27, 15); printf("%s", movie);

	int a = 0;
	for (int i = 0; i < many; i++) {
		strcat(seat1, seat[i]);
		//gotoxy(27, 17+a); printf("%s", seat[i]);
		if (seat[i][0] == 'E' || seat[i][0] == 'F') {
			if (seat[i][1] >= '4' && seat[i][1] <= '7') {
				strcat(seat1, "(����Ʈ�ڽ�)");
				//gotoxy(30, 17+a); printf("(����Ʈ�ڽ�)");
				gotoxy(27, 17 + a);
				price += 13000; printf("%s", seat1);
			}
			else {
				strcat(seat1, "(�Ϲݼ�)");
				//gotoxy(30, 17+a); printf("(�Ϲݼ�)");
				gotoxy(27, 17 + a);
				price += 10000; printf("%s", seat1);
			}
		}
		else {
			strcat(seat1, "(�Ϲݼ�)");
			//gotoxy(30, 17+a); printf("(�Ϲݼ�)");
			gotoxy(27, 17 + a);
			price += 10000; printf("%s", seat1);

		}
		memset(&seat1, 0, sizeof(char) * 30);
		a++;
	}
	gotoxy(77, 22); printf("%d", price);

	gotoxy(84, 15);
	scanf(" %c", &sale);
	if (sale == 89 || sale == 121) {
		price = price / 10 * 9;
		gotoxy(77, 22); printf("         ");
		gotoxy(77, 22); printf("%d", price);
	}
	book.price = price;
	gotoxy(0, 25); printf("                              �� �������� Ƽ���� �����Ͻðڽ��ϱ�?(Y/N): \n");
	char agree;
	gotoxy(73, 25);
	scanf(" %c", &agree);
	if (agree == 'y' || agree == 'Y') {
		FILE* fp = fopen("D:/book_mem.txt", "ab");
		fwrite(&book, sizeof(BOOK_MEM), 1, fp);
		fclose(fp);

		printf("\n\n");
		printf("                                        ������ �Ϸ�Ǿ����ϴ�.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	else {
		printf("\n\n");
		printf("                                        ������ ��ҵǾ����ϴ�.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
}