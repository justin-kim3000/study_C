#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include "struct.h"
#include "function.h"
#include <Windows.h>
#include <conio.h>
#include <string.h>

void my_rec() {
	int act = 0, hor = 0, comid = 0, drama = 0, fan = 0, crime = 0;
	char a = 0;
	int score = 0;
	int select = 0;
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
	printf("                                      KB �ó׸� ��ȭ ��õ �ý���\n");
	printf("\n\n");
	printf("                       ���ݺ��� �帣���� '����'�̶� �Ҹ��� ��ȭ 10���� �����帳�ϴ�.\n");
	printf("                 ���Բ��� �� ��ȭ�� ������ �Ű��ֽø� �ش� �����͸� ������� ���� ���� ��\n");
	printf("                              ������ ���⿡ �´� ��ȭ�� ��õ�� �帳�ϴ�.\n");
	printf("\n\n");
	printf("                             ������������������������������             ������������������������������\n");
	printf("                             �� 1. ����     ��             �� 2. ���ư��� ��\n");
	printf("                             ������������������������������             ������������������������������\n");
	printf("\n\n");
	printf("                                                                            ��� ����: ");
	gotoxy(87, 25);
	scanf("%d", &select);
	while (1) {
		if (select == 1) {
			break;
		}
		else if (select == 2) {
			return;
		}
		else {
			gotoxy(0, 25);
			printf("                                                                            ��� ����:    ");
			gotoxy(87, 25);
			scanf("%d", &select);
		}
	}

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
	printf("                                      KB �ó׸� ��ȭ ��õ �ý���\n");
	printf("\n\n");

	FILE* fpr = fopen("d:/REC_MV_LIST.txt", "rb");
	if (fpr == NULL) {
		printf("                                      ���� ��ϵ� DB�� �����ϴ�.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	RECOM rec = { 0, };            // ����� ��õ ��ȭ ��� ���
	int count = 1;
	char genre[10] = { 0, };

	while (fread(&rec, sizeof(rec), 1, fpr) == 1) {
		gotoxy(33, 27); printf("                                                 ");
		gotoxy(25, 15); printf("��������������������������������������������������������������������������������������������������������\n");
		gotoxy(25, 16); printf("��                                                  ��\n");
		gotoxy(25, 17); printf("��                      ����                        ��\n");
		gotoxy(53, 17); printf("%d\n", count++);
		gotoxy(25, 18); printf("��                                                  ��\n");
		gotoxy(25, 19); printf("��     ����:                                        ��");
		gotoxy(25, 20); printf("��     �帣:                                        ��");
		gotoxy(25, 21); printf("��     ����:                                        ��");
		gotoxy(25, 22); printf("��     �ֿ�:                                        ��");
		gotoxy(25, 23); printf("��                                                  ��");
		gotoxy(25, 24); printf("��������������������������������������������������������������������������������������������������������\n");
		gotoxy(37, 19); printf("                                       ");
		gotoxy(37, 19); printf("<%s>", rec.name);
		gotoxy(37, 20); printf("                                       ");
		gotoxy(37, 20); printf("%s", rec.genre);
		gotoxy(37, 21); printf("                                       ");
		gotoxy(37, 21); printf("%s", rec.director);
		gotoxy(37, 22); printf("                                       ");
		gotoxy(37, 22); printf("%s", rec.actor);
		gotoxy(33, 27);	printf("�� ��ȭ�� ���� ���� �ֳ���?(Y/N): ");
		scanf(" %c", &a);
		while (1) {
			if (a == 'Y' || a == 'y') {
				gotoxy(33, 27);
				printf("������ �ű�ٸ� �� ���ΰ���?(1~5): ");
				scanf("%d", &score);
				getchar();
				if (score == 1 || score == 2 || score == 3 || score == 4 || score == 5) {
				}
				else {
					gotoxy(33, 27);
					printf("������ �ű�ٸ� �� ���ΰ���?(1~5):     ");
					gotoxy(33, 27);
					printf("������ �ű�ٸ� �� ���ΰ���?(1~5): ");
					rewind(stdin);
					continue;
				}
				if (strcmp(rec.genre, "�׼�") == 0) {
					act += score;
				}
				else if (strcmp(rec.genre, "�ڹ̵�") == 0) {
					comid += score;
				}
				else if (strcmp(rec.genre, "����") == 0) {
					hor += score;
				}
				else if (strcmp(rec.genre, "���") == 0) {
					drama += score;
				}
				else if (strcmp(rec.genre, "��Ÿ��") == 0) {
					fan += score;
				}
				else if (strcmp(rec.genre, "����") == 0) {
					crime += score;
				}
				break;
			}
			else if (a == 'N' || a == 'n' && count != 11) {
				break;
			}
			else {
				gotoxy(33, 27); printf("�� ��ȭ�� ���� ���� �ֳ���?(Y/N):         ");
				gotoxy(33, 27);	printf("�� ��ȭ�� ���� ���� �ֳ���?(Y/N): ");
				scanf(" %c", &a);
			}
		}
	}
		

	

	if (act > hor && act > comid && act > drama && act > fan && act > crime) {
		strcpy(genre, "�׼�");
	}
	else if (hor > act && hor > comid && hor > drama && hor > fan && hor > crime) {
		strcpy(genre, "����");
	}
	else if (comid > act && comid > hor && comid > drama && comid > fan && comid > crime) {
		strcpy(genre, "�ڹ̵�");
	}
	else if (drama > act && drama > hor && drama > comid && drama > fan && drama > crime) {
		strcpy(genre, "���");
	}
	else if (fan > act && fan > hor && fan > comid && fan > drama && fan > crime) {
		strcpy(genre, "��Ÿ��");
	}
	else if (crime > act && crime > hor && crime > drama && crime > comid && crime > fan) {
		strcpy(genre, "����");
	}
	else
	{
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
		printf("                                      KB �ó׸� ��ȭ ��õ �ý���\n");
		printf("\n\n");
		printf("                    ��ȣ �帣�� �ʹ� ���ų�, �Է��Ͻ� �����Ͱ� ������ ��õ�� �Ұ����մϴ�.\n");
		printf("                                      ó������ �ٽ� �������ּ���.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}

	fpr = fopen("d:/NOW_MV_LIST.txt", "rb");            // ���� �帣�� ���� ���� ���� �帣�� ��µǵ��� ����
	if (fpr == NULL) {
		printf("������ �������� �����ϴ�.\n");
		return;
	}

	NOW now = { 0, };          // �� ������ �������� ���� ���� �߿� ���� ��ȣ�ϴ� ��ȭ�� ��õ �޴´�.
	int i = 0;
	int count2 = 0;
	if (genre[0] != 0) {
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
		printf("                                      KB �ó׸� ��ȭ ��õ �ý���\n");
		printf("\n\n");
		while (fread(&now, sizeof(now), 1, fpr) == 1) {
			if (strcmp(now.genre, genre) == 0) {
				gotoxy(25, 15 + i); printf("��������������������������������������������������������������������������������������������������������\n");
				gotoxy(25, 16 + i); printf("��                                                  ��\n");
				gotoxy(25, 17 + i); printf("��     ����:                                        ��");
				gotoxy(25, 18 + i); printf("��     �帣:                                        ��");
				gotoxy(25, 19 + i); printf("��                                                  ��");
				gotoxy(25, 20 + i); printf("��������������������������������������������������������������������������������������������������������\n");
				gotoxy(37, 17 + i); printf("                                       ");
				gotoxy(37, 17 + i); printf("<%s>", now.name);
				gotoxy(37, 18 + i); printf("                                       ");
				gotoxy(37, 18 + i); printf("%s", now.genre);
				count2++; i += 6;
			}
		}
		printf("\n\n\n\n");
		printf("                        ������ ��ȣ �帣�� %s�̸�, ���� ���� ��ȭ�� ��õ�մϴ�.\n", genre);
		printf("                                    �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	else if (count2 == 0)
	{
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
		printf("                                      KB �ó׸� ��ȭ ��õ �ý���\n");
		printf("\n\n");
		printf("                        ���� ���� �� ������ ��ȣ �帣�� �ش��ϴ� ��ȭ�� �����ϴ�.\n");
		printf("                                      ó������ �ٽ� �������ּ���.\n");
		printf("                                     �ƹ� Ű�� ������ ���ư��ϴ�.\n");
		_getch();
		return;
	}
	fclose(fpr);
}