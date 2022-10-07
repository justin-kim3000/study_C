#include <stdio.h>
#include "student.h"
#include "util(readWrite).h"

void studentAdd()
{
    char addMore;
    while (1)
    {
        printf("이름을 입력하시오 : ");
        scanf("%s", &st.name);
        printf("국어 성적을 입력하시오 : ");
        scanf("%d", &st.kor);
        printf("영어 성적을 입력하시오 : ");
        scanf("%d", &st.eng);
        printf("수학 성적을 입력하시오 : ");
        scanf("%d", &st.math);

        file_write(st);
        printf("종료시 N / 추가시 Y를 누르세요. : ");
        scanf(" %c", &addMore);
        if (addMore == 'n' || addMore == 'N')
        {
            break;
        }
        else
        {
            continue;
        }
    }
}
