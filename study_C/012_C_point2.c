#include <stdio.h>

int main_menu();
int add();

int main()
{
    while (1)
    {
        int menu = main_menu();
        int a, b;
        scanf("%d %d", &a, &b);
        int result = add(a, b, menu);
        switch (menu)
        {
        case 1:
            printf("덧셈의 결과 값은 : %d\n", result);
            break;
        case 2:
            printf("뺄셈의 결과 값은 : %d\n", result);
            break;
        case 3:
            printf("곱셈의 결과 값은 : %d\n", result);
            break;
        case 4:
            printf("나눗셈의 결과 값은 : %d\n", result);
            break;
        default:
            printf("1~5 숫자를 입력하세요. \n");
            break;
        }
    }
}

int main_menu()
{
    printf("---------------------\n");
    printf("간단한 계산기 App\n");
    printf("---------------------\n");
    printf("1. 덧셈 계산\n");
    printf("2. 뺄셈 계산\n");
    printf("3. 곱셈 계산\n");
    printf("4. 나눗셈 계산\n");
    printf("5. 프로그램 종료\n");
    printf("---------------------\n");
    printf("메뉴를 선택하세요.: ");
    int menu = 0;
    scanf("%d", &menu);
    if (menu == 5)
    {
        printf("프로그램이 종료되었습니다.\n");
        exit(0);
    }

    return menu;
}

int add(int a, int b, int c)
{
    int res;
    if (c == 1)
    {
        res = a + b;
    }
    else if (c == 2)
    {
        res = a - b;
    }
    else if (c == 3)
    {
        res = a * b;
    }
    else if (c == 4)
    {
        res = a / b;
    }
    else
    {
        exit(0);
    }

    return res;
}