#include "def.h"
#include <stdio.h>
#include <Windows.h>
#include <string.h>
#include "haksa.h"
#include "file_util.h"

void lect_write(LECTURE lect)
{
	FILE* fp = NULL;
	fp = fopen("d:/st_bin.bin", "ab");
	if (fp == NULL) {
		printf("������ �����Ҽ��� �����ϴ�.\n");
		return;
	}
	fwrite(&lect, sizeof(LECTURE), 1, fp);
	fclose(fp);
}

void lect_read()
{
	FILE* fpr = fopen("d:/st_bin.bin", "rb");
	if (fpr == NULL) {
		printf("������ �������� �����ϴ�.\n");
		return;
	}

	LECTURE st_t = { 0, };
	int count = 1;
	while (fread(&st_t, sizeof(LECTURE), 1, fpr) == 1) {
		printf("�л���ȣ:%d\n", count++);
		std_lect_show(st_t);
		printf("----------------------\n");
		printf("\n");
		printf("\n");

	}
	fclose(fpr);
}

// ��ü ������ ����
void lect_init()
{
	FILE* fp = NULL;
	fp = fopen("d:/st_bin.bin", "wb");
	if (fp == NULL) {
		printf("������ �����Ҽ��� �����ϴ�.\n");
		return;
	}
	fclose(fp);
}

void lect_search(char name[])
{
	FILE* fpr = fopen("d:/st_bin.bin", "rb");
	if (fpr == NULL) {
		printf("������ �������� �����ϴ�.\n");
		return;
	}

	LECTURE st_t = { 0, };
	int count = 1;
	while (fread(&st_t, sizeof(LECTURE), 1, fpr) == 1) {
		if (strcmp(name, st_t.std.name) == 0) {
			printf("�л���ȣ:%d\n", count++);
			std_lect_show(st_t);
			printf("----------------------\n");
		}
	}
	fclose(fpr);
}

void lect_search2(char *name)
{
	FILE* fpr = fopen("d:/st_bin.bin", "rb");
	if (fpr == NULL) {
		printf("������ �������� �����ϴ�.\n");
		return;
	}

	LECTURE st_t = { 0, };
	int count = 1;
	while (fread(&st_t, sizeof(LECTURE), 1, fpr) == 1) {
		if (strcmp(name, st_t.std.name) == 0) {
			printf("�л���ȣ:%d\n", count++);
			std_lect_show(st_t);
			printf("----------------------\n");
		}
	}
	fclose(fpr);
}

void lect_delete(char *name) {
	FILE* fp = fopen("d:/st_bin.bin", "rb");
	if (fp == NULL) {
		printf("������ �������� �����ϴ�.\n");
		return;
	}

	LECTURE src = { 0, };
	static LECTURE dest[256] = { 0, };
	int idx = 0;
	while (fread(&src, sizeof(LECTURE), 1, fp) == 1) {
		if (strcmp(name, src.std.name) != 0) {
			dest[idx++] = src;
			//memcpy(&dest[idx++], &src, sizeof(LECTURE));
		}
	}
	fclose(fp);

	fp = fopen("d:/st_bin.bin", "wb");
	if (fp == NULL) {
		printf("������ �����Ҽ��� �����ϴ�.\n");
		return;
	}
	for (int i = 0; i < 256; i++)
	{
		if (strcmp(dest[i].std.name, "") != 0) {
			fwrite(&dest[i], sizeof(LECTURE), 1, fp);
		}
		else break;
	}
	fclose(fp);
	memset(dest, 0, sizeof(LECTURE) * 256);
	printf("%s ������ �������Դϴ�..\n", name);
	Sleep(500);
}