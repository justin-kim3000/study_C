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
	printf("                                            蕨衙 頂羲 褻�稞n");
	printf("\n\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛        1. 煎斜檣        弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛      2. 綠�蛾� 褻��     弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("\n\n");
	printf("                                                          晦棟 摹鷗 (0戲煎 給嬴陛晦): ");
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
			printf("                                                          晦棟 摹鷗 (0戲煎 給嬴陛晦):  ");
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
	printf("                                           蕨衙 頂羲 褻�稞n");
	FILE* fp = fopen("D:/book.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	BOOK book_t = { 0, };

	char name[10] = { 0, };
	char phone[20] = { 0, };

	printf("\n\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛 蕨衙濠貲:               弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛 瞪�食醽�:               弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(48, 16); scanf("%s", &name);
	gotoxy(48, 19); scanf("%s", &phone);
	printf("\n\n\n");
	printf("                                     蕨衙 頂羲擊 褻�蜂萺埭炴�...\n");
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
	printf("                                          %s椒曖 蕨衙 頂羲\n", name);
	printf("\n\n\n");

	int count = 0;
	int line1 = 0;
	while (fread(&book_t, sizeof(book_t), 1, fp) == 1) {
		if (strcmp(name, book_t.name) == 0 && strcmp(phone, book_t.phone) == 0) {
			gotoxy(25, 15 + line1); printf("忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
			gotoxy(25, 16 + line1); printf("弛                  %d廓簞 蕨衙 頂羲                 弛\n", ++count);
			gotoxy(25, 17 + line1); printf("弛     薯跡:                                        弛");
			gotoxy(25, 18 + line1); printf("弛     謝戮:                                        弛");
			gotoxy(25, 19 + line1); printf("弛     唸薯 旎擋:                                   弛");
			gotoxy(25, 20 + line1); printf("戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
			gotoxy(37, 17 + line1); printf("                                       ");
			gotoxy(37, 17 + line1); printf("<%s>", book_t.movie);
			gotoxy(37, 18 + line1); printf("                                       ");
			gotoxy(37, 18 + line1); printf("%s %s %s", book_t.seat1, book_t.seat2, book_t.seat3);
			gotoxy(42, 19 + line1); printf("                     ");
			gotoxy(42, 19 + line1); printf("%d", book_t.price);
			//printf("                                          %d廓簞 蕨衙 頂羲\n", ++count);
			//printf("                                          艙��: %s\n", book_t.movie);
			//printf("                                          謝戮: %s %s %s\n", book_t.seat1, book_t.seat2, book_t.seat3);
			//printf("                                          唸薯 旎擋: %d\n", book_t.price);
			printf("\n");
			line1 += 6;
		}
	}
	if (count == 0) {
		fclose(fp);
		printf("                                     堅偌椒曖 蕨衙 頂羲檜 橈蝗棲棻.\n");
		printf("                                      嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	printf("\n\n");
	int i;
	printf("                            忙式式式式式式式式式式式式式忖             忙式式式式式式式式式式式式式忖\n");
	printf("                            弛 1. 給嬴陛晦 弛             弛 2. 蕨衙 鏃模弛\n");
	printf("                            戌式式式式式式式式式式式式式戎             戌式式式式式式式式式式式式式戎\n");
	printf("\n\n");
	printf("                                                                            晦棟 摹鷗: ");
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
			printf("                                             蕨衙 鏃模\n");
			*/
			char movie[40] = { 0, };
			char seat[5] = { 0, };
			gotoxy(0, 16 + i); printf("                               忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖                          \n");
			gotoxy(0, 17 + i); printf("                               弛 鏃模й 艙��:                       弛                          \n");
			gotoxy(0, 18 + i); printf("                               戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎                          \n");
			gotoxy(0, 19 + i); printf("                               忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖                          \n");
			gotoxy(0, 20 + i); printf("                               弛 鏃模й 謝戮:                       弛                          \n");
			gotoxy(0, 21 + i); printf("                               戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎                          \n");
			gotoxy(0, 22 + i); printf("                                                                                                   \n");
			gotoxy(0, 23 + i); printf("                        蕨衙и 謝戮檜 罹楝偃檣 唳辦, 羅 廓簞 謝戮擊 殮溘ж撮蹂.                        ");
			gotoxy(0, 24 + i); printf("                                    0擊 殮溘ж賊 詭景煎 給嬴骨棲棻.                        ");
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
			gotoxy(0, 28); printf("                                                                            晦棟 摹鷗:    ");
			gotoxy(0, 28); printf("                                                                            晦棟 摹鷗: ");
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
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n");
		printf("\n                                   嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
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
		printf("                                殮溘ж褐 蕨衙 頂羲檜 襄營ж雖 彊蝗棲棻.\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}

	fp = fopen("d:/book.txt", "wb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n");
		printf("\n                                   嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
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
	printf("                                     蕨衙蒂 鏃模ж朝 醞殮棲棻...\n");
	Sleep(1500);
	printf("\n");
	printf("                                     蕨衙 鏃模陛 諫猿腎歷蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
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
	printf("                                           蕨衙 頂羲 褻�稞n");
	FILE* fp = fopen("D:/book_mem.txt", "rb");
	if (fp == NULL) {
		printf("\n\n\n");
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	BOOK_MEM book_t = { 0, };

	char id[10] = { 0, };
	char passwd[20] = { 0, };

	printf("\n\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛 ID:                     弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                    忙式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                    弛 綠塵廓��:               弛\n");
	printf("                                    戌式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(42, 16);
	scanf("%s", id);
	gotoxy(48, 19);
	scanf("%s", passwd);
	int login_chk = 0;
	login_chk = check_ID(id, passwd);
	if (login_chk == 0) {
		printf("\n\n\n");
		printf("                            襄營ж雖 彊朝 ID檜剪釭, 綠塵廓�ㄟ� ぎ溜蝗棲棻.\n");
		printf("                                     �挫� �� 棻衛 衛紫п輿撮蹂.\n");
		printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	printf("\n\n\n");
	printf("                                       煎斜檣縑 撩奢ц蝗棲棻.\n");
	printf("                                     蕨衙 頂羲擊 褻�蜂萺埭炴�...\n");
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
	printf("                                          %s椒曖 蕨衙 頂羲\n", id);
	printf("\n\n\n");

	int count = 0;
	int line2 = 0;
	while (fread(&book_t, sizeof(BOOK_MEM), 1, fp) == 1) {
		if (strcmp(id, book_t.id) == 0 && strcmp(passwd, book_t.pass) == 0) {
			gotoxy(25, 15 + line2); printf("忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
			gotoxy(25, 16 + line2); printf("弛                  %d廓簞 蕨衙 頂羲                 弛\n", ++count);
			gotoxy(25, 17 + line2); printf("弛     薯跡:                                        弛");
			gotoxy(25, 18 + line2); printf("弛     謝戮:                                        弛");
			gotoxy(25, 19 + line2); printf("弛     唸薯 旎擋:                                   弛");
			gotoxy(25, 20 + line2); printf("戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
			gotoxy(37, 17 + line2); printf("                                       ");
			gotoxy(37, 17 + line2); printf("<%s>", book_t.movie);
			gotoxy(37, 18 + line2); printf("                                       ");
			gotoxy(37, 18 + line2); printf("%s %s %s", book_t.seat1, book_t.seat2, book_t.seat3);
			gotoxy(42, 19 + line2); printf("                     ");
			gotoxy(42, 19 + line2); printf("%d", book_t.price);
			printf("\n");
			line2 += 6;
			//printf("                                          %d廓簞 蕨衙 頂羲\n", ++count);
			//printf("                                          艙��: %s\n", book_t.movie);
			//printf("                                          謝戮: %s %s %s\n", book_t.seat1, book_t.seat2, book_t.seat3);
			//printf("                                          唸薯 旎擋: %d\n", book_t.price);
			printf("\n");
		}
	}
	if (count == 0) {
		fclose(fp);
		printf("                                     堅偌椒曖 蕨衙 頂羲檜 橈蝗棲棻.\n");
		printf("                                      嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	printf("\n\n");
	int i;
	printf("                            忙式式式式式式式式式式式式式忖             忙式式式式式式式式式式式式式忖\n");
	printf("                            弛 1. 給嬴陛晦 弛             弛 2. 蕨衙 鏃模弛\n");
	printf("                            戌式式式式式式式式式式式式式戎             戌式式式式式式式式式式式式式戎\n");
	printf("\n\n");
	printf("                                                                           晦棟 摹鷗: ");
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
			printf("                                             蕨衙 鏃模\n");
			*/
			char movie[40] = { 0, };
			char seat[5] = { 0, };
			printf("\n\n");
			gotoxy(0, 16 + i); printf("                               忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖                          \n");
			gotoxy(0, 17 + i); printf("                               弛 鏃模й 艙��:                       弛                          \n");
			gotoxy(0, 18 + i); printf("                               戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎                          \n");
			gotoxy(0, 19 + i); printf("                               忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖                          \n");
			gotoxy(0, 20 + i); printf("                               弛 鏃模й 謝戮:                       弛                          \n");
			gotoxy(0, 21 + i); printf("                               戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎                          \n");
			gotoxy(0, 22 + i); printf("                                                                                                   \n");
			gotoxy(0, 23 + i); printf("                        蕨衙и 謝戮檜 罹楝偃檣 唳辦, 羅 廓簞 謝戮擊 殮溘ж撮蹂.                        ");
			gotoxy(0, 24 + i); printf("                                    0擊 殮溘ж賊 詭景煎 給嬴骨棲棻.                        ");
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
			gotoxy(0, 28); printf("                                                                            晦棟 摹鷗:    ");
			gotoxy(0, 28); printf("                                                                            晦棟 摹鷗: ");
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
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n");
		printf("\n                                   嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
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
		printf("                                殮溘ж褐 蕨衙 頂羲檜 襄營ж雖 彊蝗棲棻.\n\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}

	fp = fopen("d:/book_mem.txt", "wb");
	if (fp == NULL) {
		printf("\n\n\n\n");
		printf("                                 蕨衙 頂羲 DB蒂 碳楝螃雖 跤ц蝗棲棻.\n");
		printf("                                      濡衛 �� 棻衛 衛紫п輿撮蹂.\n");
		printf("\n                                   嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
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
	printf("                                     蕨衙蒂 鏃模ж朝 醞殮棲棻...\n");
	Sleep(1500);
	printf("\n");
	printf("                                     蕨衙 鏃模陛 諫猿腎歷蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	return;
}