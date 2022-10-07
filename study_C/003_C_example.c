#include <stdio.h>
#include <string.h>

int main()
{

    int haveMoney;
    int 레쓰비 = 900, 토레타 = 1200, 코카콜라 = 1500, 카페라떼 = 1800, 스타벅스카페라떼 = 2500, 대용량아메리카노 = 4500;
    char chooseBeverage[20];

    printf("돈을 입력하세요 : ");
    scanf("%d", &haveMoney);
    rewind(stdin);

    if (haveMoney < 레쓰비)
    {
        printf("돈이 부족합니다ㅠㅠ\n");
        return 0;
    }

    printf("음료를 선택하시오. (레쓰비, 토레타, 코카콜라, 카페라떼, 스타벅스카페라떼, 대용량아메리카노) : ");
    scanf("%s", &chooseBeverage);
    rewind(stdin);

    printf("%s\n", chooseBeverage);

    // strcmp(a,b) -> a와 b를 비교하는 string연산자
    if (strcmp(chooseBeverage, "레쓰비") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 레쓰비);
    }
    else if (strcmp(chooseBeverage, "토레타") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 토레타);
    }
    else if (strcmp(chooseBeverage, "코카콜라") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 코카콜라);
    }
    else if (strcmp(chooseBeverage, "카페라떼") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 카페라떼);
    }
    else if (strcmp(chooseBeverage, "스타벅스카페라떼") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 스타벅스카페라떼);
    }
    else if (strcmp(chooseBeverage, "대용량아메리카노") == 0)
    {
        printf("감사합니다! 거스름돈은 %d원 입니다.\n", haveMoney - 대용량아메리카노);
    }
    else
    {
        printf("잘못 누르셨습니다! 다시 실행해주세요.\n");
    }
}