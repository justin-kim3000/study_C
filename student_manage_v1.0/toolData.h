#include <stdio.h>

int toolData()
{
    int select = 0;
    printf("=======================\n");
    printf("학사 관리 App v 1.0\n");
    printf("-----------------------\n");
    printf("1. 학생 정보 입력\n");
    printf("2. 학생 정보 보기\n");
    printf("3. 학생 정보 삭제\n");
    printf("4. 이름 검색\n");
    printf("5. 종료\n");
    printf("-----------------------\n");
    printf("메뉴를 선택하시오(1~5): ");
    scanf(" %d", &select);

    return select;
}