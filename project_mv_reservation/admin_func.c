#define _CRT_SECURE_NO_WARNINGS
#include "struct.h"
#include "function.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <windows.h>
#include <conio.h>

// 婦葬濠 賅萄 - 譆褐 艙�� 薯跡, 濰腦 殮溘
void admin_NOW_MV_input()
{
	NOW MV = { 0, };
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
	printf("                                KB 衛啻葆 婦葬濠辨 詭景 - 鼻艙濛 蹺陛\n");
	printf("\n\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 薯跡:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 濰腦:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(41, 16); scanf(" %[^\n]s", &MV.name);
	gotoxy(41, 19); scanf(" %s", &MV.genre);
	
	FILE* fp = NULL;
	fp = fopen("d:/NOW_MV_LIST.txt", "ab");
	if (fp == NULL) {
		printf("だ橾擊 儅撩й熱陛 橈蝗棲棻.\n");
		return;
	}
	fwrite(&MV, sizeof(NOW), 1, fp);
	printf("\n\n\n\n\n");
	printf("                                       蹺陛陛 諫猿腎歷蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	fclose(fp);
	return;
}

// 婦葬濠 賅萄 - 蹺繭 艙�� 薯跡, 濰腦 殮溘
void admin_REC_MV_input()
{
	system("cls");

	RECOM MV1 = { 0, };
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
	printf("                          KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 蹺陛\n");
	printf("\n\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 薯跡:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 濰腦:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 馬絮:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	printf("                                 忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                                 弛 輿翱:                         弛\n");
	printf("                                 戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(41, 16); scanf(" %[^\n]s", &MV1.name);
	gotoxy(41, 19); scanf(" %s", &MV1.genre);
	gotoxy(41, 22); scanf(" %[^\n]s", &MV1.director);
	gotoxy(41, 25); scanf(" %[^\n]s", &MV1.actor);

	FILE* fp = NULL;
	fp = fopen("d:/REC_MV_LIST.txt", "ab");
	if (fp == NULL) {
		printf("                          橾衛瞳戲煎 だ橾擊 翮雖 跤ц蝗棲棻. 棻衛 衛紫п輿撮蹂.\n");
		printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fclose(fp);
		return;
	}
	fwrite(&MV1, sizeof(RECOM), 1, fp);
	printf("\n\n\n\n\n");
	printf("                                       蹺陛陛 諫猿腎歷蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	fclose(fp);
	return;
}


void NOW_MV_del()
{
	FILE* fpr = fopen("d:/NOW_MV_LIST.txt", "rb");
	if (fpr == NULL) {
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
		printf("                             KB 衛啻葆 婦葬濠辨 詭景 - ⑷營 鼻艙濛 餉薯\n");
		printf("\n\n");
		printf("                                     ⑷營 蛔煙脹 DB陛 橈蝗棲棻.\n");
		printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fpr = fopen("D:/NOW_MV_LIST.txt", "wb");
		fclose(fpr);
		return;
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
	printf("                             KB 衛啻葆 婦葬濠辨 詭景 - ⑷營 鼻艙濛 餉薯\n");
	char movie[40] = { 0, };
	char seat[5] = { 0, };
	printf("\n\n");
	printf("                              忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                              弛 餉薯й 艙��:                     弛\n");
	printf("                              戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(45, 16); scanf(" %[^\n]s", &movie);

	NOW MV_R = { 0, };
	static NOW dest[256] = { 0, };
	int idx = 0;
	int found = 0;

	while (fread(&MV_R, sizeof(NOW), 1, fpr) == 1) {
		if (strcmp(movie, MV_R.name) != 0)
		{
			memcpy(&dest[idx++], &MV_R, sizeof(NOW));
		}
		else {
			found = 1;
		}
	}
	fclose(fpr);
	if (found == 0)
	{
		printf("\n\n\n\n");
		printf("                             殮溘ж褐 艙�降� 襄營ж雖 彊蝗棲棻.\n"); 
		printf("                                嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	fpr = fopen("d:/NOW_MV_LIST.txt", "wb");
	if (fpr == NULL) {
		printf("だ橾擊 儅撩й熱陛 橈蝗棲棻.\n");
		return;
	}

	for (int i = 0; i < 256; i++) {
		if (strcmp(dest[i].name, "") != 0) {
			fwrite(&dest[i], sizeof(NOW), 1, fpr);
		}
		else break;
	}
	fclose(fpr);
	memset(dest, 0, sizeof(NOW) * 256);
	printf("\n\n\n\n");
	printf("                                       餉薯陛 諫猿腎歷蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	return;
}

// 蹺繭 艙�� 薑爾 餉薯
void REC_MV_del(){
	FILE* fpr = fopen("d:/REC_MV_LIST.txt", "rb");
	if (fpr == NULL) {
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
		printf("                         KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 餉薯\n");
		printf("\n\n");
		printf("                                    ⑷營 蛔煙脹 DB陛 橈蝗棲棻.\n");
		printf("                                   嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fpr = fopen("D:/REC_MV_LIST.txt", "wb");
		fclose(fpr);
		return;
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
	printf("                         KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 餉薯\n");
	char movie[40] = { 0, };
	char seat[5] = { 0, };
	printf("\n\n");
	printf("                              忙式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                              弛 餉薯й 艙��:                     弛\n");
	printf("                              戌式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式戎\n");
	gotoxy(45, 16); scanf(" %[^\n]s", &movie);

	RECOM	MV_E = { 0, };
	static RECOM dest[256] = { 0, };
	int idx = 0;
	int found = 0;

	while (fread(&MV_E, sizeof(RECOM), 1, fpr) == 1) {
		if (strcmp(movie, MV_E.name) != 0)
		{
			memcpy(&dest[idx++], &MV_E, sizeof(RECOM));
		}
		else {
			found = 1;
		}
	}
	fclose(fpr);


	if (found == 0)
	{
		printf("\n\n\n\n");
		printf("                                    殮溘ж褐 艙�降� 襄營ж雖 彊蝗棲棻.\n");
		printf("                                       嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	fpr = fopen("d:/REC_MV_LIST.txt", "wb");
	if (fpr == NULL) {
		printf("だ橾擊 儅撩й熱陛 橈蝗棲棻.\n");
		return;
	}

	for (int i = 0; i < 256; i++) {
		if (strcmp(dest[i].name, "") != 0) {
			fwrite(&dest[i], sizeof(RECOM), 1, fpr);
		}
		else break;
	}
	fclose(fpr);
	memset(dest, 0, sizeof(RECOM) * 256);
	printf("\n\n\n\n");
	printf("                                          餉薯陛 諫猿腎歷蝗棲棻.\n");
	printf("                                       嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	return;

}

void NOW_MV_read()
{
	NOW now = { 0, };
	FILE* fp = fopen("D:/NOW_MV_LIST.txt", "rb");
	if (fp == NULL) {
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
		printf("                              KB 衛啻葆 婦葬濠辨 詭景 - ⑷營 鼻艙濛 跡煙\n");
		printf("\n\n");
		printf("                                   ⑷營 蛔煙脹 鼻艙濛檜 橈蝗棲棻.\n");
		printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fp = fopen("D:/NOW_MV_LIST.txt", "wb");
		fclose(fp);
		return;
	}
	int x = 24, y = 18;
	int i = 0;
	int count = 0;
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
	printf("                              KB 衛啻葆 婦葬濠辨 詭景 - ⑷營 鼻艙濛 跡煙\n");
	printf("\n\n");
	printf("                  忙式式式式式式式式式式成式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式成式式式式式式式式式式式式式式式式式式式式忖\n");
	printf("                  弛   牖嬪   弛              薯跡             弛         濰腦       弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式弛\n");
	printf("                  弛          弛                               弛                    弛\n");
	printf("                  戌式式式式式式式式式式扛式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式扛式式式式式式式式式式式式式式式式式式式式戎\n");
	while (fread(&now, sizeof(now), 1, fp) == 1) {
		gotoxy(x, y + i); printf("%d", ++count);
		gotoxy(x + 7, y + i); printf("%s", now.name);
		gotoxy(x + 39, y + i); printf("%s", now.genre);
		i += 2;
	}
	if (count == 0) {
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
		printf("                              KB 衛啻葆 婦葬濠辨 詭景 - ⑷營 鼻艙濛 跡煙\n");
		printf("\n\n");
		printf("                                   ⑷營 蛔煙脹 鼻艙濛檜 橈蝗棲棻.\n");
		printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fclose(fp);
		return;
	}
	gotoxy(0, 40);
	printf("                                 ⑷營 鼻艙醞檣 艙�韭� 嬪諦 偽蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	fclose(fp);
}

// 蹺繭濛 檗晦 л熱
void REC_MV_read()
{
	RECOM rec = { 0, };
	FILE* fp = fopen("D:/REC_MV_LIST.txt", "rb");
	if (fp == NULL) {
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
		printf("                           KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 跡煙\n");
		printf("\n\n");
		printf("                                      ⑷營 蛔煙脹 DB陛 橈蝗棲棻.\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fp = fopen("D:/REC_MV_LIST.txt", "wb");
		fclose(fp);
		return;
	}
	int x = 13, y = 18;
	int i = 0;
	int count = 0;
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
	printf("                           KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 跡煙\n");
	printf("\n\n");
	printf("       忙式式式式式式式式式式成式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式成式式式式式式式式式式式忖\n");
	printf("       弛   廓��   弛                           薯跡                                弛    濰腦   弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戍式式式式式式式式式式托式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式托式式式式式式式式式式式扣\n");
	printf("       弛          弛                                                               弛           弛\n");
	printf("       戌式式式式式式式式式式扛式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式扛式式式式式式式式式式式戎\n");
	while (fread(&rec, sizeof(rec), 1, fp) == 1) {
		gotoxy(x, y + i); printf("%d", ++count);
		gotoxy(x + 7, y + i); printf("%s (馬絮: %s, 輿翱: %s)", rec.name, rec.director, rec.actor);
		gotoxy(x + 71, y + i); printf("%s", rec.genre);
		i += 2;
	}
	if (count == 0) {
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
		printf("                           KB 衛啻葆 婦葬濠辨 詭景 - 摹�� 濰腦 碟戮辨 DB 跡煙\n");
		printf("\n\n");
		printf("                                      ⑷營 蛔煙脹 DB陛 橈蝗棲棻.\n");
		printf("                                     嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		fclose(fp);
		return;
	}
	gotoxy(0, 44);
	printf("                                  ⑷營 蛔煙脹 DB朝 嬪諦 偽蝗棲棻.\n");
	printf("                                    嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
	_getch();
	fclose(fp);
}

void book_init() {
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
	printf("                               KB 衛啻葆 婦葬濠辨 詭景 - 蕨衙 頂羲 蟾晦�苒n");
	printf("\n\n");
	printf("                                  盪濰脹 賅萇 蕨衙 頂羲擊 蟾晦�倆桭炴�.\n");
	printf("                                        薑蜓 霞чж衛啊蝗棲梱?\n");
	printf("                                      (唳堅! 給檜鑒 熱 橈蝗棲棻!)\n");
	printf("\n\n");
	printf("                             忙式式式式式式式式式式式式式忖             忙式式式式式式式式式式式式式忖\n");
	printf("                             弛 1. 餉薯     弛             弛 2. 鏃模     弛\n");
	printf("                             戌式式式式式式式式式式式式式戎             戌式式式式式式式式式式式式式戎\n");
	printf("\n\n");
	printf("                                                                           晦棟 摹鷗: ");
	int select = 0;
	scanf("%d", &select);
	if (select == 1) {
		FILE* fp = fopen("D:/book.txt", "wb");
		fclose(fp);
		fp = fopen("D:/book_mem.txt", "wb");
		fclose(fp);
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
		printf("                               KB 衛啻葆 婦葬濠辨 詭景 - 蕨衙 頂羲 蟾晦�苒n");
		printf("\n\n");
		printf("                                   賅萇 蕨衙 頂羲檜 蟾晦�音Ц�蝗棲棻.\n");
		printf("                                      嬴鼠 酈釭 援腦賊 給嬴骨棲棻.\n");
		_getch();
		return;
	}
	else {
		rewind(stdin);
		return;
	}
	
	
}