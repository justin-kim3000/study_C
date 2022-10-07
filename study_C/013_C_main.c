#include <stdio.h>
#include <string.h>
#include "013_C_student2.h"
#include "013_C_util.h"

int main()
{
    ST st1 = {"홍길동", 100, 90, 80, 0, 0, 'a'};
    ST st2 = {"둔길동", 40, 30, 50, 0, 0, 'a'};
    ST st3 = {"고길동", 10, 40, 90, 0, 0, 'a'};
    init_stduent();
    show_student(st);
    file_write(st1);
    file_read();
}