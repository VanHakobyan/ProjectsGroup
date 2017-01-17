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
                #region armEng
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

                #endregion

                #region engArm
                if (word[i] == '1') arm[i] = 'է';
                if (word[i] == '2') arm[i] = 'թ';
                if (word[i] == '3') arm[i] = 'փ';
                if (word[i] == '4') arm[i] = 'ձ';
                if (word[i] == '5') arm[i] = 'ջ';
                if (word[i] == '7') arm[i] = 'և';
                if (word[i] == '8') arm[i] = 'ր';
                if (word[i] == '9') arm[i] = 'չ';
                if (word[i] == '0') arm[i] = 'ճ';
                if (word[i] == '=') arm[i] = 'ժ';
                if (word[i] == 'q') arm[i] = 'ք';
                if (word[i] == 'w') arm[i] = 'ո';
                if (word[i] == 'e') arm[i] = 'ե';
                if (word[i] == 'r') arm[i] = 'ռ';
                if (word[i] == 't') arm[i] = 'տ';
                if (word[i] == 'y') arm[i] = 'ը';
                if (word[i] == 'u') arm[i] = 'ւ';
                if (word[i] == 'i') arm[i] = 'ի';
                if (word[i] == 'o') arm[i] = 'օ';
                if (word[i] == 'p') arm[i] = 'պ';
                if (word[i] == '[') arm[i] = 'խ';
                if (word[i] == ']') arm[i] = 'ծ';
                if (word[i] == 'a') arm[i] = 'ա';
                if (word[i] == 's') arm[i] = 'ս';
                if (word[i] == 'd') arm[i] = 'դ';
                if (word[i] == 'f') arm[i] = 'ֆ';
                if (word[i] == 'g') arm[i] = 'գ';
                if (word[i] == 'h') arm[i] = 'հ';
                if (word[i] == 'j') arm[i] = 'յ';
                if (word[i] == 'k') arm[i] = 'կ';
                if (word[i] == 'l') arm[i] = 'լ';
                if (word[i] == 'z') arm[i] = 'զ';
                if (word[i] == 'x') arm[i] = 'ղ';
                if (word[i] == 'c') arm[i] = 'ց';
                if (word[i] == 'v') arm[i] = 'վ';
                if (word[i] == 'b') arm[i] = 'բ';
                if (word[i] == 'n') arm[i] = 'ն';
                if (word[i] == 'm') arm[i] = 'մ';
                if (word[i] == ' ') arm[i] = ' ';
                if (word[i] == '-') arm[i] = '-';
                if (word[i] == '`') arm[i] = '`';
                if (word[i] == ',') arm[i] = ',';

                #endregion

            }
            return arm;
        }
    }
}
