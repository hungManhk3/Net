using System.Net.NetworkInformation;

namespace Max
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tạo một chương trình dạng Console, sử dụng.NET 8, cho phép nhập vào 5 số nguyên và in ra số lớn nhất trong 5 số(sử dụng cấu trúc if ()).
            //Tìm hiểu các quy tắc đặt tên định danh trong C# và trả lời những câu hỏi sau:
            //Những ký tự nào được phép sử dụng khi đặt tên định danh?
            //            Ký tự đầu tiên: phải là chữ cái(A–Z, a–z) hoặc dấu gạch dưới _

            //            Các ký tự tiếp theo: có thể là chữ cái, chữ số(0–9) hoặc gạch dưới _

            //            Không được bắt đầu bằng số

            //            Không được dùng khoá từ(keywords) như int, class, if, while, v.v., trừ khi thêm @ phía trước, ví dụ: @int
            //Tên định danh trong C# có phân biệt chữ hoa chữ thường hay không? 
            //          Co
            //Có thể đặt tên biến bằng các ký tự tiếng Việt không(ă, â, ư, ô, ắ, ê, ế, ề...) ?
            //          Co nhung khong khuyen khich
            int[] số = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"nhap so thu {i + 1}: ");
                //number[i] = int.Parse(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out số[i]))
                {
                    Console.Write("nhap lai: ");
                }

            }
            var max = số[0];
            if (max < số[1]) 
                max = số[1];
            if (max < số[2])
                max = số[2];
            if (max < số[3])
                max = số[3];
            if (max < số[4])
                max = số[4];
            Console.WriteLine($"so lon nhat trong 5 so la: {max}");


        }
    }
}
