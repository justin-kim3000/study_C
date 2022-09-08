#include <stdio.h>

int main()
{
    int N, M;
    scanf("%d %d %d", &N, &M);

    if (M <= N && (M != 1 && M != 2))
    {
        printf("OLDBIE!");
    }
    else if (M == 1 || M == 2)
    {
        printf("NEWBIE!");
    }
    else
    {
        printf("TLE!");
    }

    return 0;
}