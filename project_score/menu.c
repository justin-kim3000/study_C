#include "def.h"
#include <stdio.h>
#include "menu.h"
#include <Windows.h>

int main_menu()
{
	printf("=========================\n");
	printf("����Ʈ �л� ���� v1.0\n");
	printf("=========================\n");
	printf("1. �л� ���� �Է�\n");
	printf("2. �л� ���� ����\n");
	printf("3. �л� ���� ����\n");
	printf("4. �л� ���� ����\n");
	printf("5. ���� �˻�\n");
	printf("6. ������ �ʱ�ȭ\n");
	printf("7. ����\n");
	printf("=========================\n");
	printf("�޴� ����:");
	int menu = 0;
	scanf("%d", &menu);

	if (menu == 1 || menu == 2 || menu == 3 || menu == 4 || menu == 5 || menu == 6 || menu == 7)
	{
		return menu;
	}


}