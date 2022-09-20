#include <stdio.h>
// 함수의 기본형태
// 1. void 함수명()
// 2. void 함수명(매개변수)
// 3. 데이터타입 함수명()
// 4. 데이터타입 함수명(매개변수)
// 매개변수 : 외부에서 함수내부로 정보 전달(인자, 인수, 파라미터)

void func1(); // 함수 프로토타입
void func2(int num);
int func3();
int func4(int n1, int n2);

int main()
{
    printf("HI!\n");
    func1(); //함수의 호출
    func2(100);
    int aaa = 1000;
    func2(aaa);
    printf("%d\n", func3());
    int bbb = func3();

    printf("%d\n", func4(5, 10));
}

// 1번 형태
void func1() // 함수의 정의
{
    printf("hi! func1\n");
    func2(50);
}

// 2번 형태
void func2(int num)
{
    num += 200;
    printf("매개변수 num: %d\n", num);
    // 강제종료 용으로 사용하기도 한다.
    return;
}

// 3번 형태 - return(반환값) 필요
int func3()
{
    int n1 = 100;
    int n2 = 100;
    int sum = n1 + n2;
    printf("%d\n", sum);
    return sum;
}

// 4번째 형태
int func4(int n1, int n2)
{
    return n1 + n2;
}