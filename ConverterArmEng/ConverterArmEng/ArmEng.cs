using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterArmEng
{
    public static class ArmEng
    {
        public static char[] ConvertEng(this string word)
        {
            char[] arm = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                //a	b	c	d	e	f	g	h	i	j	k	l	m	n	o	p	q	r	s	t	u	v	w	x	y	z

                if (word[i] == 'է') arm[i] = '1';
                if (word[i] == 'թ') arm[i] = '2';
                if (word[i] == 'փ') arm[i] = '3';
                if (word[i] == 'ձ') arm[i] = '4';
                if (word[i] == 'ջ') arm[i] = '5';
                if (word[i] == 'և') arm[i] = '7';
                if (word[i] == 'ր') arm[i] = '8';
                if (word[i] == 'չ') arm[i] = '9';
                if (word[i] == 'ճ') arm[i] = '0';
                if (word[i] == 'ժ') arm[i] = '=';
                if (word[i] == 'ք') arm[i] = 'q';
                if (word[i] == 'ո') arm[i] = 'w';
                if (word[i] == 'ե') arm[i] = 'e';
                if (word[i] == 'ռ') arm[i] = 'r';
                if (word[i] == 'տ') arm[i] = 't';
                if (word[i] == 'ը') arm[i] = 'y';
                if (word[i] == 'ւ') arm[i] = 'u';
                if (word[i] == 'ի') arm[i] = 'i';
                if (word[i] == 'օ') arm[i] = 'o';
                if (word[i] == 'պ') arm[i] = 'p';
                if (word[i] == 'խ') arm[i] = '[';
                if (word[i] == 'ծ') arm[i] = ']';
                if (word[i] == 'ա') arm[i] = 'a';
                if (word[i] == 'ս') arm[i] = 's';
                if (word[i] == 'դ') arm[i] = 'd';
                if (word[i] == 'ֆ') arm[i] = 'f';
                if (word[i] == 'գ') arm[i] = 'g';
                if (word[i] == 'հ') arm[i] = 'h';
                if (word[i] == 'յ') arm[i] = 'j';
                if (word[i] == 'կ') arm[i] = 'k';
                if (word[i] == 'լ') arm[i] = 'l';
                if (word[i] == 'զ') arm[i] = 'z';
                if (word[i] == 'ղ') arm[i] = 'x';
                if (word[i] == 'ց') arm[i] = 'c';
                if (word[i] == 'վ') arm[i] = 'v';
                if (word[i] == 'բ') arm[i] = 'b';
                if (word[i] == 'ն') arm[i] = 'n';
                if (word[i] == 'մ') arm[i] = 'm';
                if (word[i] == ' ') arm[i] = ' ';
                if (word[i] == '-') arm[i] = '-';
                if (word[i] == '`') arm[i] = '`';
                if (word[i] == ',') arm[i] = ',';
                
                
            }
            return arm;
        }
    }
}
