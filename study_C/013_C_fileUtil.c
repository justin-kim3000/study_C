#include <stdio.h>
#include <string.h>
// #include "013_C_util.h"
#include "student.h"

void file_write(ST st1)
{
    FILE *fp = NULL; //파일 포인터
    // w: write(쓰기), a: append(추가), r: read(읽기)
    fp = fopen("st_bin.bin", "wb");
    if (fp == NULL)
    {
        printf("파일을 생성 할 수가 없습니다.\n");
        return;
    }

    for (int i = 0; i < 10; i++)
    {
        fwrite(&st1, sizeof(st1), 1, fp);
        // fwrite(&st2, sizeof(st2), 1, fp);
        // fwrite(&st3, sizeof(st3), 1, fp);
    }
    fclose(fp);

    ST st_t = {
        0,
    };

    int count = 1;
    FILE *fpr = fopen("st_bin.bin", "rb");
    if (fpr == NULL)
    {
        printf("파일을 생성 할 수가 없습니다.\n");
        return;
    }

    while (fread(&st_t, sizeof(st_t), 1, fpr) == 1)
    {
        printf("================\n");
        printf("학생번호 : %d \n", count++);
        printf("새로운 학생 정보 \n");
        printf("================\n");
        printf("학생 이름:%s\n", st_t.name);
        printf("학생 국어:%d\n", st_t.kor);
        printf("학생 영어:%d\n", st_t.eng);
        printf("학생 수학:%d\n\n", st_t.math);
    }

    fclose(fpr);
}