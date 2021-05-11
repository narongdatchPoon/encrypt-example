using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bellugg_encrypt
{
    public partial class Form1 : Form
    {
        int count_digi = 18;
        int[] result;
        int[] result2;
        string first_char_key;
        string last_char_key;
        public Form1()
        {
            InitializeComponent();
            result = new int[count_digi];
            result2 = new int[count_digi];
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            result = new int[count_digi];
            var data = tb_data.Text;
            var private_key = tb_privatekey.Text;
            


            var first_char_data = data.Substring(0, 1);
             first_char_key = private_key.Substring(0, 1);

            var last_char_data = data.Substring(data.Length - 1, 1);
             last_char_key = private_key.Substring(private_key.Length - 1, 1);


            int shift_digi = (Convert.ToInt32(first_char_data) + Convert.ToInt32(first_char_key)) + (Convert.ToInt32(last_char_data) + Convert.ToInt32(last_char_key));

            var mod_shift = shift_digi % (count_digi-1);
            int[] key_shift = new int[count_digi];
            int i = 0;
            foreach (char digi_key in tb_privatekey.Text)
            {
                var index = (i + mod_shift) % (count_digi);
                key_shift[index] = (int)Char.GetNumericValue(digi_key);
                i++;
            }

            int[] data_int_ary = new int[count_digi];
            i = 0;
            foreach (char digi_data in tb_data.Text)
            {
                data_int_ary[i] = (int)Char.GetNumericValue(digi_data); 
                i++;
            }

            
            result[0] = shift_digi;
            for (i = 0; i < count_digi; i++)
            {
                if (i != 0)
                {
                    result[i] = key_shift[i] + data_int_ary[i];
                }
            }


            //print
            for (i = 0; i < count_digi; i++)
            {
                tb_result.Text += "[" + result[i] + "]";
            }

            for (i = 0; i < count_digi; i++)
            {
                tb_code.Text +=  (char)(result[i]+65) ;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var code = tb_code.Text;
            char[] code_ary = new char[count_digi];
            int i = 0;

            for (i = 0; i < count_digi; i++) {
                code_ary[i] = Convert.ToChar(code.Substring(i, 1));
            }

            var shift_digi = Convert.ToInt32(code_ary[0]) - 65;
            var mod_shift = shift_digi % (count_digi - 1);
            int[] key_shift = new int[count_digi];
            i = 0;
            foreach (char digi_key in tb_privatekey.Text)
            {
                var index = (i + mod_shift) % (count_digi);
                key_shift[index] = (int)Char.GetNumericValue(digi_key);
                i++;
            }

           
            for (i = 0; i < count_digi; i++)
            {
                if (i != 0)
                {
                    result2[i] = (Convert.ToInt32(code_ary[i])-65) - key_shift[i];
                }
            }
            result2[0] = shift_digi - (result2[count_digi-1] + Convert.ToInt32(first_char_key) + Convert.ToInt32(last_char_key));

            //print
            for (i = 0; i < count_digi; i++)
            {
                tb_decode.Text += "[" + result2[i] + "]";
            }

        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            List<String> decriptList = new List<string>();
            for (int j = 0; j < 10000000; j++)
            {
                

               // tb_data_run.Text = data;
                //tb_code_run.Text = result_encript;
                Task<String> encript = AccessTheWebAsync(j.ToString(), tb_privatekey.Text);
                String string_encript = encript.Result;


                if (!decriptList.Contains(string_encript))
                {
                    decriptList.Add(string_encript);
                    tb_data_run.Text = j.ToString();
                    tb_code_run.Text = string_encript;
                }
                else
                {
                    MessageBox.Show(string_encript + "  ////  " + j);
                    break;
                }
            }

            MessageBox.Show("not duplicate");
        }


        async Task<String> AccessTheWebAsync(String data_ , String pv)
        {
            string data = data_.ToString().PadLeft(8, '0');

            var private_key = pv;

            var first_char_data = data.Substring(0, 1);
            var first_char_key = private_key.Substring(0, 1);

            var last_char_data = data.Substring(data.Length - 1, 1);
            var last_char_key = private_key.Substring(private_key.Length - 1, 1);


            int shift_digi = (Convert.ToInt32(first_char_data) + Convert.ToInt32(first_char_key)) + (Convert.ToInt32(last_char_data) + Convert.ToInt32(last_char_key));

            var mod_shift = shift_digi % (8 - 1);
            int[] key_shift = new int[8];
            int i = 0;
            foreach (char digi_key in private_key)
            {
                var index = (i + mod_shift) % (count_digi);
                key_shift[index] = (int)Char.GetNumericValue(digi_key);
                i++;
            }

            int[] data_int_ary = new int[count_digi];
            i = 0;
            foreach (char digi_data in data)
            {
                data_int_ary[i] = (int)Char.GetNumericValue(digi_data);
                i++;
            }

            result = new int[count_digi];
            result[0] = shift_digi;

            for (i = 0; i < count_digi; i++)
            {
                if (i != 0)
                {
                    result[i] = key_shift[i] + data_int_ary[i];
                }
            }


            var result_encript = "";

            for (i = 0; i < count_digi; i++)
            {
                result_encript += (char)(result[i] + 65);
            }

            
            return result_encript;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var intDateTime = "";
            foreach (var x in result2)
            {
                intDateTime += x;
            }
            DateTime dt = new DateTime(Convert.ToInt64(intDateTime));
            tb_datetime.Text = dt.ToLongDateString()  + dt.ToLongTimeString();
        }
    }
}
