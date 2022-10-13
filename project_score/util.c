#include "def.h"
#include <stdio.h>
#include <time.h>
#include <stdlib.h>
#include <string.h>
#include "util.h"

void get_time(char* tinfo)
{
	time_t timer;
	struct tm* t;
	// timer: 1970�� 1��1�� 0�� 0�ʺ��� ~ ������� ��
	timer = time(NULL);
	t = localtime(&timer);
	char buf[40] = { 0, };
	sprintf(buf, "%d��%d��%d��-%d��%d��%d��",
		t->tm_year + 1900,
		t->tm_mon + 1,
		t->tm_mday,
		t->tm_hour,
		t->tm_min,
		t->tm_sec);
	strcpy(tinfo, buf);
}