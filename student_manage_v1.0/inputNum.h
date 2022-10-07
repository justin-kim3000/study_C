#include <stdio.h>
#include <string.h>
#include "student_add.h"
#include "student.h"
#include "util(readWrite).h"

void inputNum(int select)
{
    if (select == 1)
    {
        studentAdd();
    }
    else if (select == 2)
    {
        file_read();
    }
    else if (select == 3)
    {
        file_del(st);
    }
    else if (select == 4)
    {

        FILE *fpr = fopen("st_bin.bin", "rb");
        if (fpr == NULL)
        {
            printf("파일을 생성 할 수가 없습니다.\n");
            return;
        }
        ST st_t = {
            0,
        };
        char findName[10];
        printf("찾을 이름을 입력하시오: ");
        scanf("%s", &findName);
        while (fread(&st_t, sizeof(st_t), 1, fpr) == 1)
        {

            if (strcmp(st_t.name, findName) == 0)
            {
                printf("================\n");
                printf("학생 이름:%s\n", st_t.name);
                printf("학생 국어:%d\n", st_t.kor);
                printf("학생 영어:%d\n", st_t.eng);
                printf("학생 수학:%d\n\n", st_t.math);
                break;
            }
            else
            {
                printf("찾는 이름이 없어요.\n");
                break;
            }
        }

        fclose(fpr);
    }
    else if (select == 5)
    {
        return;
    }
    else
    {
        printf("\n");
        printf("1~5사이의 숫자를 입력하시오.\n");
        printf("\n");
        toolData();
    }
}