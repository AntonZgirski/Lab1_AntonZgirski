using System;

namespace Lab1
{
  class Program
  {
    static void Main(string[] args)
    {
      bool b,b1 = true,b2 = false;
      sbyte s,s1 = 10, s2 = 3;
      byte byt, byt1 = 10, byt2 = 3;
      short sh, sh1 = 10, sh2 = 3;
      ushort ush, ush1 = 10, ush2 = 3;
      int i, i1 = 10, i2 = 3;
      uint uin, uin1 = 10, uin2 = 3;
      long l, l1 = 10, l2 = 3;
      ulong ul, ul1 = 10, ul2 = 3;
      double d, d1 = 10.0, d2 = 3.0;
      float fl, fl1 = 10, fl2 = 3;
      char ch, ch1 = 'A', ch2 = 'B';

      // bool 
      Console.WriteLine("bool");
      Console.WriteLine("b1 = " + b1 + "\t" + "b2 = " + b2);
      //b = b1 + b2;
      //b = b1 - b2;
      //b = b1 * b2;
      //b = b1 / b2;
      //b = b1 % b2;
      //b = b1++;
      //b = b1--;
      //b = ++b1;
      //b = --b1;
      b = b1 & b2;
      Console.WriteLine(b1 + " & " + b2 + " = " + b);
      b = b1 | b2;
      Console.WriteLine(b1 + " | " + b2 + " = " + b);
      b = b1 ^ b2;
      Console.WriteLine(b1 + " ^ " + b2 + " = " + b);
      //b = b1 >> b2;
      //b = b1 << b2;
      b = b1 == b2;
      Console.WriteLine(b1 + " == " + b2 + " = " + b);
      b = b1 != b2;
      Console.WriteLine(b1 + " != " + b2 + " = " + b);
      //b = b1 > b2;     
      //b = b1 < b2;     
      //b = b1 >= b2;
      //b = b1 <= b2;
      b = b1 == b2 ? b1 : b2;
      Console.WriteLine(b1 + " == " + b2 + " ? " + " = " + b);

      // sbyte 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("sbyte");
      Console.WriteLine("s1 = " + s1 + " \t " + "s2 = " + s2);

      //s = s1 + s2;
      //s = s1 - s2;
      //s = s1 * s2;
      //s = s1 / s2;
      //s = s1 % s2;
      s = s1++;      
      Console.WriteLine("10++ = " + s);
      s1 = 10;
      s = s1--;
      Console.WriteLine("10-- = " + s);
      s1 = 10;
      s = ++s1;
      Console.WriteLine("++10 = " + s);
      s1 = 10;
      s = --s1;
      Console.WriteLine("--10 = " + s);
      s1 = 10;
      //s = s1 & s2;      
      //s = s1 | s2;
      //s = s1 ^ s2;      
      //s1 = s1 >> s2;
      //s1 = s1 << s2;
      //s = s1 == s2;
      //s = s1 != s2;
      //s = s1 > s2;
      //s = s1 < s2;
      //s = s1 >= s2;
      //s = s1 <= s2;
      s = s1 == s2 ? s1 : s2;
      Console.WriteLine(s1 + " == " + s2 + " ? " + "= " + s);

      // byte 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("byte");
      Console.WriteLine("byt1 = " + byt1 + "\t" + "byt2 = " + byt2);

      //byt = byt1 + byt2;
      //byt = byt1 - byt2;
      //byt = byt1 * byt2;
      //byt = byt1 / byt2;
      //byt = byt1 % byt2;
      byt = byt1++;
      Console.WriteLine("10++ = " + byt);
      byt1 = 10;
      byt = byt1--;
      Console.WriteLine("10-- = " + byt);
      byt1 = 10;
      byt = ++byt1;
      Console.WriteLine("++10 = " + byt);
      byt1 = 10;
      byt = --byt;
      Console.WriteLine("--10 = " + byt);
      byt1 = 10;
      //byt = byt1 & byt2;
      //byt = byt1 | byt2;
      //byt = byt1 ^ byt2;
      //byt = byt1 >> byt2;
      //byt = byt1 << byt2;
      //byt = byt1 == byt2;
      //byt = byt1 != byt2;
      //byt = byt1 > byt2;
      //byt = byt1 < byt2;
      //byt = byt1 >= byt2;
      //byt = byt1 <= byt2;
      byt = byt1 == byt2 ? byt1 : byt2;
      Console.WriteLine(byt1 + " == " + byt + " ? " + "=" + byt);

      // short 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("short");
      Console.WriteLine("sh1 = " + sh1 + "\t" + "sh2 = " + sh2);

      //sh = sh1 + sh2;
      //sh = sh1 - sh2;
      //sh = sh1 * sh2;
      //sh = sh1 / sh2;
      //sh = sh1 % sh2;
      sh = sh1++;
      Console.WriteLine("10++ = " + sh);
      sh1 = 10;
      sh = sh1--;
      Console.WriteLine("10-- = " + sh);
      sh1 = 10;
      sh = ++sh1;
      Console.WriteLine("++10 = " + sh);
      sh1 = 10;
      sh = --sh;
      Console.WriteLine("--10 = " + sh);
      sh1 = 10;
      //sh = sh1 & sh2;
      //sh = sh1 | sh2;
      //sh = sh1 ^ sh2;
      //sh = sh1 >> sh2;
      //sh = sh1 << sh2;
      //sh = sh1 == sh2;
      //sh = sh1 != sh2;
      //sh = sh1 > sh2;
      //sh = sh1 < sh2;
      //sh = sh1 >= sh2;
      //sh = sh1 <= sh2;
      sh = sh1 == sh2 ? sh1 : sh2;
      Console.WriteLine(sh1 + " == " + sh2 + " ? " + "=" + sh);

      // ushort 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("ushort");
      Console.WriteLine("ush1 = " + ush1 + "\t" + "ush2 = " + ush2);

      //ush = ush1 + ush2;
      //ush = ush1 - ush2;
      //ush = ush1 * ush2;
      //ush = ush1 / ush2;
      //ush = ush1 % ush2;
      ush = ush1++;
      Console.WriteLine("10++ = " + ush);
      ush1 = 10;
      ush = ush1--;
      Console.WriteLine("10-- = " + ush);
      ush1 = 10;
      ush = ++ush1;
      Console.WriteLine("++10 = " + ush);
      ush1 = 10;
      ush = --ush;
      Console.WriteLine("--10 = " + ush);
      ush1 = 10;
      //ush = ush1 & ush2;
      //ush = ush1 | ush2;
      //ush = ush1 ^ ush2;
      //ush = ush1 >> ush2;
      //ush = ush1 << ush2;
      //ush = ush1 == ush2;
      //ush = ush1 != ush2;
      //ush = ush1 > ush2;
      //ush = ush1 < ush2;
      //ush = ush1 >= ush2;
      //ush = ush1 <= ush2;
      ush = ush1 == ush2 ? ush1 : ush2;
      Console.WriteLine(ush1 + " == " + ush2 + " ? " + "=" + ush);

      // int 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("int");
      Console.WriteLine("i1 = " + i1 + "\t" + "i2 = " + i2);

      i = i1 + i2;
      Console.WriteLine(i1 + " + " + i2 + " = " + i);
      i = i1 - i2;
      Console.WriteLine(i1 + " - " + i2 + " = " + i);
      i = i1 * i2;
      Console.WriteLine(i1 + " * " + i2 + " = " + i);
      i = i1 / i2;
      Console.WriteLine(i1 + " / " + i2 + " = " + i);
      i = i1 % i2;
      Console.WriteLine(i1 + " % " + i2 + " = " + i);
      i = i1++;
      Console.WriteLine("10++ = " + i);
      i1 = 10;
      i = i1--;
      Console.WriteLine("10-- = " + i);
      i1 = 10;
      i = ++i1;
      Console.WriteLine("++10 = " + i);
      i1 = 10;
      i = --i1;
      Console.WriteLine("--10 = " + i);
      i1 = 10;
      i = i1 & i2;
      Console.WriteLine(i1 + " & " + i2 + " = " + i);
      i = i1 | i2;
      Console.WriteLine(i1 + " | " + i2 + " = " + i);
      i = i1 ^ i2;
      Console.WriteLine(i1 + " ^ " + i2 + " = " + i);
      i = i1 >> i2;
      Console.WriteLine(i1 + " >> " + i2 + " = " + i);
      i = i1 << i2;
      Console.WriteLine(i1 + " << " + i2 + " = " + i);
      //i = i1 == i2;
      //i = i1 != i2;
      //i = i1 > i2;
      //i = i1 < i2;
      //i = i1 >= i2;
      //i = i1 <= i2;
      i = i1 == i2 ? i1 : i2;
      Console.WriteLine(i1 + " == " + i2 + " ? " + "=" + i);

      // uint 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("uint");
      Console.WriteLine("uin1 = " + uin1 + "\t" + "uin2 = " + uin2);

      uin = uin1 + uin2;
      Console.WriteLine(uin1 + " + " + uin2 + " = " + uin);
      uin = uin1 - uin2;
      Console.WriteLine(uin1 + " - " + uin2 + " = " + uin);
      uin = uin1 * uin2;
      Console.WriteLine(uin1 + " * " + uin2 + " = " + uin);
      uin = uin1 / uin2;
      Console.WriteLine(uin1 + " / " + uin2 + " = " + uin);
      uin = uin1 % uin2;
      Console.WriteLine(uin1 + " % " + uin2 + " = " + uin);
      uin = uin1++;
      Console.WriteLine("10++ = " + uin);
      uin1 = 10;
      uin = uin1--;
      Console.WriteLine("10-- = " + uin);
      uin1 = 10;
      uin = ++uin1;
      Console.WriteLine("++10 = " + uin);
      uin1 = 10;
      uin = --uin1;
      Console.WriteLine("--10 = " + uin);
      uin1 = 10;
      uin = uin1 & uin2;
      Console.WriteLine(uin1 + " & " + uin2 + " = " + uin);
      uin = uin1 | uin2;
      Console.WriteLine(uin1 + " | " + uin2 + " = " + uin);
      uin = uin1 ^ uin2;
      Console.WriteLine(uin1 + " ^ " + uin2 + " = " + uin);
      //uin = uin1 >> uin2;
      //uin = uin1 << uin2;
      //uin = uin1 == uin2;
      //uin = uin1 != uin2;
      //uin = uin1 > uin2;
      //uin = uin1 < uin2;
      //uin = uin1 >= uin2;
      //uin = uin1 <= uin2;
      uin = uin1 == uin2 ? uin1 : uin2;
      Console.WriteLine(uin1 + " == " + uin2 + " ? " + "=" + uin);

      // long 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("long");
      Console.WriteLine("l1 = " + l1 + "\t" + "l2 = " + l2);

      l = l1 + l2;
      Console.WriteLine(l1 + " + " + l2 + " = " + l);
      l = l1 - l2;
      Console.WriteLine(l1 + " - " + l2 + " = " + l);
      l = l1 * l2;
      Console.WriteLine(l1 + " * " + l2 + " = " + l);
      l = l1 / l2;
      Console.WriteLine(l1 + " / " + l2 + " = " + l);
      l = l1 % l2;
      Console.WriteLine(l1 + " % " + l2 + " = " + l);
      l = l1++;
      Console.WriteLine("10++ = " + l);
      l1 = 10;
      l = l1--;
      Console.WriteLine("10-- = " + l);
      l1 = 10;
      l = ++l1;
      Console.WriteLine("++10 = " + l);
      l1 = 10;
      l = --l1;
      Console.WriteLine("--10 = " + l);
      l1 = 10;
      l = l1 & l2;
      Console.WriteLine(l1 + " & " + l2 + " = " + l);
      l = l1 | l2;
      Console.WriteLine(l1 + " | " + l2 + " = " + l);
      l = l1 ^ l2;
      Console.WriteLine(l1 + " ^ " + l2 + " = " + l);
      //l = l1 >> l2;
      //l = l1 << l2;
      //l = l1 == l2;
      //l = l1 != l2;
      //l = l1 > l2;
      //l = l1 < l2;
      //l = l1 >= l2;
      //l = l1 <= l2;
      l = l1 == l2 ? l1 : l2;
      Console.WriteLine(l1 + " == " + l2 + " ? " + "=" + l);

      // ulong 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("ulong");
      Console.WriteLine("ul1 = " + ul1 + "\t" + "ul2 = " + ul2);

      ul = ul1 + ul2;
      Console.WriteLine(ul1 + " + " + ul2 + " = " + ul);
      ul = ul1 - ul2;
      Console.WriteLine(ul1 + " - " + ul2 + " = " + ul);
      ul = ul1 * ul2;
      Console.WriteLine(ul1 + " * " + ul2 + " = " + ul);
      ul = ul1 / ul2;
      Console.WriteLine(ul1 + " / " + ul2 + " = " + ul);
      ul = ul1 % ul2;
      Console.WriteLine(ul1 + " % " + ul2 + " = " + ul);
      ul = ul1++;
      Console.WriteLine("10++ = " + ul);
      ul1 = 10;
      ul = ul1--;
      Console.WriteLine("10-- = " + ul);
      ul1 = 10;
      ul = ++ul1;
      Console.WriteLine("++10 = " + ul);
      ul1 = 10;
      ul = --ul1;
      Console.WriteLine("--10 = " + ul);
      ul1 = 10;
      ul = ul1 & ul2;
      Console.WriteLine(ul1 + " & " + ul2 + " = " + ul);
      ul = ul1 | ul2;
      Console.WriteLine(ul1 + " | " + ul2 + " = " + ul);
      ul = ul1 ^ ul2;
      Console.WriteLine(ul1 + " ^ " + ul2 + " = " + ul);
      //ul = ul1 >> ul2;
      //ul = ul1 << ul2;
      //ul = ul1 == ul2;
      //ul = ul1 != ul2;
      //ul = ul1 > ul2;
      //ul = ul1 < ul2;
      //ul = ul1 >= ul2;
      //ul = ul1 <= ul2;
      ul = ul1 == ul2 ? ul1 : ul2;
      Console.WriteLine(ul1 + " == " + ul2 + " ? " + "=" + ul);

      // double 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("double");
      Console.WriteLine("d1 = " + d1 + "\t" + "d2 = " + d2);

      d = d1 + d2;
      Console.WriteLine(d1 + " + " + d2 + " = " + d);
      d = d1 - d2;
      Console.WriteLine(d1 + " - " + d2 + " = " + d);
      d = d1 * d2;
      Console.WriteLine(d1 + " * " + d2 + " = " + d);
      d = d1 / d2;
      Console.WriteLine(d1 + " / " + d2 + " = " + d);
      d = d1 % d2;
      Console.WriteLine(d1 + " % " + d2 + " = " + d);
      d = d1++;
      Console.WriteLine("10++ = " + d);
      d1 = 10;
      d = d1--;
      Console.WriteLine("10-- = " + d);
      d1 = 10;
      d = ++d1;
      Console.WriteLine("++10 = " + d);
      d1 = 10;
      d = --d1;
      Console.WriteLine("--10 = " + d);
      d1 = 10;
      //d = d1 & d2;
      //d = d1 | d2;
      //d = d1 ^ d2;
      //d = d1 >> d2;      
      //d = d1 << d2;
      //d = d1 == d2;
      //d = d1 != d2;
      //d = d1 > d2;
      //d = d1 < d2;
      //d = d1 >= d2;
      //d = d1 <= d2;
      d = d1 == d2 ? d1 : d2;
      Console.WriteLine(d1 + " == " + d2 + " ? " + "=" + d);

      // float 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("float");
      Console.WriteLine("fl1 = " + fl1 + "\t" + "fl2 = " + fl2);

      fl = fl1 + fl2;
      Console.WriteLine(fl1 + " + " + fl2 + " = " + fl);
      fl = fl1 - fl2;
      Console.WriteLine(fl1 + " - " + fl2 + " = " + fl);
      fl = fl1 * fl2;
      Console.WriteLine(fl1 + " * " + fl2 + " = " + fl);
      fl = fl1 / fl2;
      Console.WriteLine(fl1 + " / " + fl2 + " = " + fl);
      fl = fl1 % fl2;
      Console.WriteLine(fl1 + " % " + fl2 + " = " + fl);
      fl = fl1++;
      Console.WriteLine("10++ = " + fl);
      fl1 = 10;
      fl = fl1--;
      Console.WriteLine("10-- = " + fl);
      fl1 = 10;
      fl = ++fl1;
      Console.WriteLine("++10 = " + fl);
      fl1 = 10;
      fl = --fl1;
      Console.WriteLine("--10 = " + fl);
      fl1 = 10;
      //fl = fl1 & fl2;
      //fl = fl1 | fl2;
      //fl = fl1 ^ fl2;
      //fl = fl1 >> fl2;
      //fl = fl1 << fl2;
      //fl = fl1 == fl2;
      //fl = fl1 != fl2;
      //fl = fl1 > fl2;
      //fl = fl1 < fl2;
      //fl = fl1 >= fl2;
      //fl = fl1 <= fl2;
      fl = fl1 == fl2 ? fl1 : fl2;
      Console.WriteLine(fl1 + " == " + fl2 + " ? " + "=" + fl);

      // char 
      Console.WriteLine("_____________________________________");
      Console.WriteLine("char");
      Console.WriteLine("ch1 = " + ch1 + "\t" + "ch2 = " + ch2);

      //ch = ch1 + ch2;
      //ch = ch1 - ch2;
      //ch = ch1 * ch2;
      //ch = ch1 / ch2;
      //ch = ch1 % ch2;
      ch = ch1++;
      Console.WriteLine("A++ = " + ch);
      ch1 = 'A';
      ch = ch1--;
      Console.WriteLine("A-- = " + ch);
      ch1 = 'A';
      ch = ++ch1;
      Console.WriteLine("++A = " + ch);
      ch1 = 'A';
      ch = --ch1;
      Console.WriteLine("--A = " + ch);
      ch1 = 'A';
      //ch = ch1 & ch2;
      //ch = ch1 | ch2;
      //ch = ch1 ^ ch2;
      //ch = ch1 >> ch2;
      //ch = ch1 << ch2;
      //ch = ch1 == ch2;
      //ch = ch1 != ch2;
      //ch = ch1 > ch2;
      //ch = ch1 < ch2;
      //ch = ch1 >= ch2;
      //ch = ch1 <= ch2;
      ch = ch1 == ch2 ? ch1 : ch2;
      Console.WriteLine(ch1 + " == " + ch2 + " ? " + "=" + ch);

    }
  }
}