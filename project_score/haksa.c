#include "def.h"
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <windows.h>
#include "haksa.h"
#include "util.h"
#include "file_util.h"

void std_lecture_input()
{
	LECTURE lect = { 0, };
	printf("#######################\n");
	printf("������û ������ �Է��մϴ�\n");
	printf("#######################\n");
	printf("�л� �̸��� �Է��ϼ���: ");
	scanf("%s", lect.std.name);
	printf("�й��� �Է��ϼ���: ");
	scanf("%d", &lect.std.std_id);
	printf("������ �Է��ϼ���: ");
	scanf("%s", lect.std.major);
	printf("���̸� �Է��ϼ���: ");
	scanf("%d", &lect.std.age);
	printf("��ȭ��ȣ�� �Է��ϼ���: ");
	scanf("%s", lect.std.tel);
	printf("�ּҸ� �Է��ϼ���: ");
	getchar();
	gets_s(lect.std.addr, sizeof(char)*40);
	//scanf("%s", lect.std.addr);
	printf("Email�� �Է��ϼ���: ");
	scanf("%s", lect.std.email);

	printf("\n------ ��� ���� ���� ------\n");
	printf("�������� �Է��ϼ���: ");
	scanf("%s", lect.prof.name);
	printf("��� ������ �Է��ϼ���: ");
	scanf("%s", lect.prof.major);
	printf("��ȭ��ȣ�� �Է��ϼ���: ");
	scanf("%s", lect.prof.tel);
	printf("Email�� �Է��ϼ���: ");
	scanf("%s", lect.prof.email);

	printf("\n------ ��û ���� ���� ------\n");
	printf("1��° ������ �Է��ϼ���: ");
	scanf("%s", lect.major[0].name);
	lect.major[0].hakjum = 3;
	printf("2��° ������ �Է��ϼ���: ");
	scanf("%s", lect.major[1].name);
	lect.major[1].hakjum = 4;
	printf("3��° ������ �Է��ϼ���: ");
	scanf("%s", lect.major[2].name);
	lect.major[2].hakjum = 3;

	// ������û ��¥
	char curtime[40] = { 0, };
	get_time(curtime);
	strcpy(lect.date, curtime);
	printf("���ǽ��� �Է��ϼ���: ");
	scanf("%s", lect.class_room);

	printf("\n������û���� �ۼ����Դϴ�...\n");
	Sleep(2000); // 1000ms = 1sec
	system("cls");
	std_lect_show(lect);
	lect_write(lect);
}

void std_lect_show(LECTURE lect)
{
	printf("\n");
	printf("############################\n");
	printf("%s ������û��\n", lect.std.name);
	printf("############################\n");
	printf("�й�: %d\n", lect.std.std_id);
	printf("�����а�: %s\n", lect.std.major);
	printf("��ȭ��ȣ: %s\n", lect.std.tel);
	printf("�ּ�: %s\n", lect.std.addr);
	printf("Email: %s\n", lect.std.email);
	printf("\n");

	printf("------ ��� ���� ���� ------\n");
	printf("�̸�: %s\n", lect.prof.name);
	printf("����: %s\n", lect.prof.major);
	printf("��ȭ: %s\n", lect.prof.tel);
	printf("Email: %s\n", lect.prof.email);
	printf("\n");

	printf("------ ��û ���� ��� ------\n");
	for (int i = 0; i < 3; i++) {
		printf("��û����%d:%s, ����:%d\n",
			i + 1, lect.major[i].name, lect.major[i].hakjum);
	}
	printf("\n");

	printf("------ ��Ÿ ���� ���� ------\n");
	printf("��û��¥: %s\n", lect.date);
	printf("���ǽ�: %s\n", lect.class_room);
}