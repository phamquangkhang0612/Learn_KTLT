using System;
namespace LearnKTLT
{
	public class Array2D
	{
		static void Main(string[] args)
		{
			Console.Write("Nhap so dong(row): ");
			int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot(col): ");
            int col = int.Parse(Console.ReadLine());

			int[,] intArrB = new int[row, col];
            RandomInputEmlement(ref intArrB);
            PrintArr(intArrB);
            Console.Write("Nhap k: "); int k = int.Parse(Console.ReadLine());
            PrintRowK(intArrB, k);
            Console.WriteLine();
            PrintColK(intArrB, k);
            Console.WriteLine();
            Console.WriteLine(SumArr(intArrB));
            
            Console.ReadKey();
		}
            
        // Viết hàm nhập mảng 2 chiều lưu các số nguyên(bao gồm việc nhập kích thước và khởi tạo mảng)
		public static void Input2DArray(out int[,] intArr)
		{
            Console.Write("Nhap so dong (row): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot (col): ");
            int col = int.Parse(Console.ReadLine());

			intArr = new int[row, col];

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        // (mảng đã được khởi tạo trước)
        public static void InputEmlements(ref int[,] intArr)
        {
            int row = intArr.GetLength(0);
            int col = intArr.GetLength(1);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    intArr[r, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        //Random cho cac gia tri cua mang
        public static void RandomInputEmlement(ref int[,] intArr)
        {
            int row = intArr.GetLength(0);
            int col = intArr.GetLength(1);

            Random a = new Random();

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    intArr[r, c] = a.Next(1, 10); ;
                }
            }
        }

        // Xuat mang
        public static void PrintArr(int[,] intArr)
        {
            for (int c = 0; c < intArr.GetLength(0); c++)
            {
                for (int l = 0; l < intArr.GetLength(1); l++)
                {
                    Console.Write(intArr[c, l] + " ");
                }
                Console.WriteLine();
            }
        }

        // Nhan vào một mảng 2 chiều lưu số nguyên a và số k in ra dòng dữ liệu ở dòng k.
        public static void PrintRowK(int[,] intArr, int k)
        {
            for(int c = 0; c < intArr.GetLength(1); c++)
            {
                Console.Write(intArr[k-1,c]+" ");
            }
        }

        // Nhan vào một mảng 2 chiều lưu số nguyên a và số k in ra dòng dữ liệu ở cột k.
        public static void PrintColK(int[,] intArr, int k)
        {
            for (int r = 0; r < intArr.GetLength(0); r++)
            {
                Console.Write(intArr[r, k - 1] + " ");
            }
        }

        // Tinh tong cac gia tri cua mang
        public static int SumArr(int[,] intArr)
        {
            int sum = 0;

            for(int r = 0; r < intArr.GetLength(0); r++)
            {
                for (int c = 0; c < intArr.GetLength(1); c++)
                {
                    sum += intArr[r, c];
                }

            }

            return sum;
        }

        // tinh trung binh cong cua cac cot
        public static void AvgArr()
        {
            Console.Write("Nhap so dong(row): ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot(col): ");
            int col = int.Parse(Console.ReadLine());

            int[,] intArrB = new int[row, col];
            RandomInputEmlement(ref intArrB);

            int sumAvgStu = 0, sumAvgSubject = 0;
            List<float> avgStu, avgSubject;

            for(int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++)
                {
                    sumAvgStu += intArrB[r, c];
                }
                avgStu[]
            }

        }

    }
}

