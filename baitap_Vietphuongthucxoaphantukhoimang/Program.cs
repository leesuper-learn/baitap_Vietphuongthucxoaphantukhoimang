using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace baitap_Vietphuongthucxoaphantukhoimang
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Random mảng
            Random rnd = new Random();
            Console.Write("Nhap kich thuoc cua mang: ");
            int input = int.Parse(Console.ReadLine());
            if (input <= 0)
            {
                Console.Write("Kich thuoc mang qua nho. Xin nhap lai: ");
                input = int.Parse(Console.ReadLine());
            }
            else if (input > 1000)
            {
                Console.Write("Kich thuoc mang qua lon. Xin nhap lai: ");
                input = int.Parse(Console.ReadLine());
            }
            int[] arr = new int[input];
            for (int i = 0; i < input; i++)
            {
                arr[i] = rnd.Next(1, 1000);
            }
            // In ra mảng
            Console.WriteLine("Ta duoc mang la: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            //Check giá trị nhập từ bàn phím và xóa nếu có
            Console.Write("Nhap gia tri can xoa: ");
            int value = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < input; i++)
            {
                if (value == arr[i])
                {
                    string access;
                    Console.Write("Gia tri dang o vi tri : " + (i + 1) + ". Ban co muon xoa khong??(Y/N): ");
                    access = Console.ReadLine();
                    if (access == "Y")
                    {
                        for (int j = i; j < input - 1; j++)
                        {
                            arr[j] = arr[j + 1];
                        }
                        input--;
                        Console.WriteLine("Đa xoa. Ta co mang moi la: ");
                        for (int k = 0; k < input; k++)
                        {
                            Console.WriteLine(arr[k] + " ");
                        }
                        Console.WriteLine();
                        check = true;
                        break;
                    }
                    else if (access == "N")
                    {
                        Console.Write("Khong xoa. Xin nhap lai gia tri: ");
                        value = int.Parse(Console.ReadLine());
                        break;
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("Gia tri khong co o trong mang.");
            }

            Console.ReadKey();
        }
    }
}
