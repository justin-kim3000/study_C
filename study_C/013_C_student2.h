#include <stdio.h>
#include <string.h>
#include "student.h"

void init_stduent()
{
    strcpy(st.name, "kill");
    st.kor = 100;
    st.eng = 80;
    st.math = 70;
    st.hap = st.kor + st.eng + st.math;
    st.avg = st.hap / 3;

    printf("good\n");
}

void show_student(ST st)
{
}