using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Создается локальная переменная "fromX", которая создается значением, полученным из текстового поля "txtX1",
            //преобразованного в целое число с помощью метода "int.Parse"
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);
            if (fromX > toX)
            {
                //Если начальное значение fromX больше конечного значения toX, 
                 //то выводится сообщение с ошибкой, и текстовые поля txtX1 и txtX2 очищаются.
                MessageBox.Show("должно быть: x1<x2","Неверно");
                txtX1.Text = "";
                txtX2.Text = "";
            }
            if (fromY > toY)
            {
                MessageBox.Show("должно быть: y1<y2","Неверно");
                txtY1.Text = "";
                txtY2.Text = "";
            }
            /*Во внешнем цикле "for" создается переменная "x" и создается значением "fromX".Цикл будет выполняться,
              пока "x" не превысит значение "toX", а после каждой итерации значение "x" будет увеличиваться на 1.
              Во внутреннем цикле "for" создается переменная "y" и создается значением "fromY".Цикл будет выполняться,
              пока "y" не превысит значение "toY", а после каждой итерации значение "y" будет увеличиваться на 1.
              Внутри вложенных циклов, используя метод "Items.Add", в список "lstResult" добавляется строка,
              которая формируется с помощью интерполяции строк Она содержит выражение "z(x,y) = x - y", где "x" и "y" - текущие значения переменных, полученные внутри циклов*/
            for (int x = fromX; x <= toX; x++)
            {
                for (int y = fromY; y <= toY; y++)
                {
                    lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }
        }
    }
}
