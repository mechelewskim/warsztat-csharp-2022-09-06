using System;

int a = int.MaxValue;  // 2147483647
int b = int.MinValue;  //-2147483648

int c = a + 1;         //-2147483648

long d = long.MaxValue;  // 9223372036854775807
long e = long.MinValue;  //-9223372036854775808

long f = a;
//int g = d; //error: Cannot implicitly convert type 'long' to 'int'.